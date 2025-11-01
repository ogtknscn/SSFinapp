using Microsoft.EntityFrameworkCore;
using SSFinapp.Domain.Entities;

namespace SSFinapp.Data.Repositories;

/// <summary>
/// Cari hesap hareketi repository implementation
/// </summary>
public class CurrentAccountTransactionRepository : GenericRepository<CurrentAccountTransaction>, ICurrentAccountTransactionRepository
{
    public CurrentAccountTransactionRepository(ApplicationDbContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<CurrentAccountTransaction>> GetTransactionsByCustomerIdAsync(int customerId)
    {
        return await _dbSet
            .Include(ct => ct.Musteri)
            .Where(ct => ct.MusteriId == customerId)
            .OrderByDescending(ct => ct.Tarih)
            .ToListAsync();
    }
    
    public async Task<IEnumerable<CurrentAccountTransaction>> GetTransactionsByDateRangeAsync(DateTime startDate, DateTime endDate)
    {
        return await _dbSet
            .Include(ct => ct.Musteri)
            .Where(ct => ct.Tarih >= startDate && ct.Tarih <= endDate)
            .OrderByDescending(ct => ct.Tarih)
            .ToListAsync();
    }
    
    public async Task<decimal> GetCustomerBalanceAsync(int customerId)
    {
        var transactions = await _dbSet
            .Where(ct => ct.MusteriId == customerId)
            .ToListAsync();
            
        return transactions.Sum(ct => ct.Alinan - ct.Verilen);
    }
}

