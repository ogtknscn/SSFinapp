using Microsoft.EntityFrameworkCore;
using SSFinapp.Domain.Entities;

namespace SSFinapp.Data.Repositories;

/// <summary>
/// Müşteri repository implementation
/// </summary>
public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(ApplicationDbContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<Customer>> GetActiveCustomersAsync()
    {
        return await _dbSet.Where(c => c.Aktif).ToListAsync();
    }
    
    public async Task<Customer?> GetCustomerWithTransactionsAsync(int id)
    {
        return await _dbSet
            .Include(c => c.CariHareketler)
            .FirstOrDefaultAsync(c => c.Id == id);
    }
}

