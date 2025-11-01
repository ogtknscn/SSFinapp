using SSFinapp.Domain.Entities;

namespace SSFinapp.Data.Repositories;

/// <summary>
/// Cari hesap hareketi repository interface
/// </summary>
public interface ICurrentAccountTransactionRepository : IRepository<CurrentAccountTransaction>
{
    Task<IEnumerable<CurrentAccountTransaction>> GetTransactionsByCustomerIdAsync(int customerId);
    Task<IEnumerable<CurrentAccountTransaction>> GetTransactionsByDateRangeAsync(DateTime startDate, DateTime endDate);
    Task<decimal> GetCustomerBalanceAsync(int customerId);
}

