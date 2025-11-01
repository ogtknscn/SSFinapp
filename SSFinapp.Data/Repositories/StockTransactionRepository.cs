using Microsoft.EntityFrameworkCore;
using SSFinapp.Domain.Entities;

namespace SSFinapp.Data.Repositories;

/// <summary>
/// Stok hareketi repository implementation
/// </summary>
public class StockTransactionRepository : GenericRepository<StockTransaction>, IStockTransactionRepository
{
    public StockTransactionRepository(ApplicationDbContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<StockTransaction>> GetTransactionsByProductIdAsync(int productId)
    {
        return await _dbSet
            .Include(st => st.Urun)
            .Where(st => st.UrunId == productId)
            .OrderByDescending(st => st.Tarih)
            .ToListAsync();
    }
    
    public async Task<IEnumerable<StockTransaction>> GetTransactionsByDateRangeAsync(DateTime startDate, DateTime endDate)
    {
        return await _dbSet
            .Include(st => st.Urun)
            .Where(st => st.Tarih >= startDate && st.Tarih <= endDate)
            .OrderByDescending(st => st.Tarih)
            .ToListAsync();
    }
}

