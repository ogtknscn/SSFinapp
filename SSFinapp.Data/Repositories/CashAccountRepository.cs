using Microsoft.EntityFrameworkCore;
using SSFinapp.Domain.Entities;

namespace SSFinapp.Data.Repositories;

public class CashAccountRepository : GenericRepository<CashAccount>, ICashAccountRepository
{
    public CashAccountRepository(ApplicationDbContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<CashAccount>> GetActiveAccountsAsync()
    {
        return await _dbSet.Where(a => a.Aktif).ToListAsync();
    }
}

