using Microsoft.EntityFrameworkCore;
using SSFinapp.Domain.Entities;
using SSFinapp.Domain.Enums;

namespace SSFinapp.Data.Repositories;

public class CashTransactionRepository : GenericRepository<CashTransaction>, ICashTransactionRepository
{
    public CashTransactionRepository(ApplicationDbContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<CashTransaction>> GetTransactionsByCashAccountIdAsync(int cashAccountId)
    {
        return await _dbSet
            .Include(t => t.Kasa)
            .Where(t => t.KasaId == cashAccountId)
            .OrderByDescending(t => t.Tarih)
            .ToListAsync();
    }
    
    public async Task<decimal> GetCashAccountBalanceAsync(int cashAccountId)
    {
        var transactions = await _dbSet
            .Where(t => t.KasaId == cashAccountId)
            .ToListAsync();
            
        decimal giris = transactions
            .Where(t => t.IslemTipi == CashTransactionType.Giris)
            .Sum(t => t.Tutar);
            
        decimal cikis = transactions
            .Where(t => t.IslemTipi == CashTransactionType.Cikis)
            .Sum(t => t.Tutar);
            
        return giris - cikis;
    }
}

