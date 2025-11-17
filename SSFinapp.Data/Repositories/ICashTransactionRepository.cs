using SSFinapp.Domain.Entities;

namespace SSFinapp.Data.Repositories;

public interface ICashTransactionRepository : IRepository<CashTransaction>
{
    Task<IEnumerable<CashTransaction>> GetTransactionsByCashAccountIdAsync(int cashAccountId);
    Task<decimal> GetCashAccountBalanceAsync(int cashAccountId);
}

