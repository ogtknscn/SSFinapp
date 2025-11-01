using Microsoft.EntityFrameworkCore;
using SSFinapp.Domain.Entities;

namespace SSFinapp.Data.Repositories;

/// <summary>
/// Ürün repository implementation
/// </summary>
public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<Product>> GetActiveProductsAsync()
    {
        return await _dbSet.Where(p => p.Aktif).ToListAsync();
    }
    
    public async Task<Product?> GetProductWithTransactionsAsync(int id)
    {
        return await _dbSet
            .Include(p => p.StokHareketleri)
            .FirstOrDefaultAsync(p => p.Id == id);
    }
}

