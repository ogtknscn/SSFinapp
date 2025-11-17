using SSFinapp.Domain.Entities;

namespace SSFinapp.Data.Repositories;

public interface ICashAccountRepository : IRepository<CashAccount>
{
    Task<IEnumerable<CashAccount>> GetActiveAccountsAsync();
}

