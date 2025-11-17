using SSFinapp.Data.Repositories;
using SSFinapp.Domain.Entities;
using SSFinapp.Domain.Enums;
using SSFinapp.Domain.Exceptions;
using SSFinapp.Domain.Validation;

namespace SSFinapp.Business.Services;

/// <summary>
/// Stok yönetimi servisi implementation
/// </summary>
public class StockService : IStockService
{
    private readonly IProductRepository _productRepository;
    private readonly IStockTransactionRepository _stockTransactionRepository;
    
    public StockService(
        IProductRepository productRepository,
        IStockTransactionRepository stockTransactionRepository)
    {
        _productRepository = productRepository;
        _stockTransactionRepository = stockTransactionRepository;
    }
    
    // Product operations
    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _productRepository.GetAllAsync();
    }
    
    public async Task<IEnumerable<Product>> GetActiveProductsAsync()
    {
        return await _productRepository.GetActiveProductsAsync();
    }
    
    public async Task<Product?> GetProductByIdAsync(int id)
    {
        return await _productRepository.GetByIdAsync(id);
    }
    
    public async Task<Product> AddProductAsync(Product product)
    {
        // Validasyon
        if (!ValidationHelper.IsValidString(product.Ad, 200))
            throw new ValidationException("Ürün adı geçersiz veya çok uzun!");
            
        if (string.IsNullOrWhiteSpace(product.Birim))
            throw new ValidationException("Birim boş olamaz!");
            
        return await _productRepository.AddAsync(product);
    }
    
    public async Task UpdateProductAsync(Product product)
    {
        await _productRepository.UpdateAsync(product);
    }
    
    public async Task DeleteProductAsync(int id)
    {
        // Stok hareketi kontrolü
        var transactions = await _stockTransactionRepository.GetTransactionsByProductIdAsync(id);
        if (transactions.Any())
        {
            throw new CannotDeleteException("Ürün", "Bu ürünün stok hareketleri var!");
        }
        
        // Fiziksel silme (hard delete)
        await _productRepository.DeleteAsync(id);
    }
    
    // Stock transaction operations
    public async Task<IEnumerable<StockTransaction>> GetAllTransactionsAsync()
    {
        return await _stockTransactionRepository.GetAllAsync();
    }
    
    public async Task<IEnumerable<StockTransaction>> GetTransactionsByProductIdAsync(int productId)
    {
        return await _stockTransactionRepository.GetTransactionsByProductIdAsync(productId);
    }
    
    public async Task<StockTransaction> AddTransactionAsync(StockTransaction transaction)
    {
        // Validasyon
        if (!ValidationHelper.IsPositiveNumber(transaction.Miktar))
            throw new ValidationException("Miktar sıfırdan büyük olmalıdır!");
            
        // Çıkış işlemi ise stok kontrolü
        if (transaction.IslemTipi == TransactionType.Cikis)
        {
            var currentStock = await GetCurrentStockLevelAsync(transaction.UrunId);
            if (currentStock < transaction.Miktar)
            {
                throw new InsufficientStockException(transaction.Miktar, currentStock);
            }
        }
        
        return await _stockTransactionRepository.AddAsync(transaction);
    }
    
    public async Task UpdateTransactionAsync(StockTransaction transaction)
    {
        await _stockTransactionRepository.UpdateAsync(transaction);
    }
    
    public async Task DeleteTransactionAsync(int id)
    {
        await _stockTransactionRepository.DeleteAsync(id);
    }
    
    // Stock level calculations
    public async Task<decimal> GetCurrentStockLevelAsync(int productId)
    {
        var transactions = await _stockTransactionRepository.GetTransactionsByProductIdAsync(productId);
        
        decimal giris = transactions
            .Where(t => t.IslemTipi == TransactionType.Giris)
            .Sum(t => t.Miktar);
            
        decimal cikis = transactions
            .Where(t => t.IslemTipi == TransactionType.Cikis)
            .Sum(t => t.Miktar);
            
        return giris - cikis;
    }
    
    public async Task<Dictionary<int, decimal>> GetAllStockLevelsAsync()
    {
        var products = await _productRepository.GetAllAsync();
        var stockLevels = new Dictionary<int, decimal>();
        
        foreach (var product in products)
        {
            var level = await GetCurrentStockLevelAsync(product.Id);
            stockLevels[product.Id] = level;
        }
        
        return stockLevels;
    }
    
    // Dashboard statistics
    public async Task<int> GetCriticalStockCountAsync(decimal threshold = 10)
    {
        var stockLevels = await GetAllStockLevelsAsync();
        // Stok seviyesi threshold'dan düşük veya negatif olan ürünler
        return stockLevels.Count(sl => sl.Value <= threshold);
    }
}

