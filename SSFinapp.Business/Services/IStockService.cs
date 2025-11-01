using SSFinapp.Domain.Entities;
using SSFinapp.Domain.Enums;

namespace SSFinapp.Business.Services;

/// <summary>
/// Stok yönetimi servisi interface
/// </summary>
public interface IStockService
{
    // Product operations
    Task<IEnumerable<Product>> GetAllProductsAsync();
    Task<IEnumerable<Product>> GetActiveProductsAsync();
    Task<Product?> GetProductByIdAsync(int id);
    Task<Product> AddProductAsync(Product product);
    Task UpdateProductAsync(Product product);
    Task DeleteProductAsync(int id);
    
    // Stock transaction operations
    Task<IEnumerable<StockTransaction>> GetAllTransactionsAsync();
    Task<IEnumerable<StockTransaction>> GetTransactionsByProductIdAsync(int productId);
    Task<StockTransaction> AddTransactionAsync(StockTransaction transaction);
    Task UpdateTransactionAsync(StockTransaction transaction);
    Task DeleteTransactionAsync(int id);
    
    // Stock level calculations
    Task<decimal> GetCurrentStockLevelAsync(int productId);
    Task<Dictionary<int, decimal>> GetAllStockLevelsAsync();
}

