using SSFinapp.Data.Repositories;

namespace SSFinapp.Data;

/// <summary>
/// Unit of Work pattern - Transaction yönetimi
/// </summary>
public interface IUnitOfWork : IDisposable
{
    IProductRepository Products { get; }
    IStockTransactionRepository StockTransactions { get; }
    ICustomerRepository Customers { get; }
    ICurrentAccountTransactionRepository CurrentAccountTransactions { get; }
    ICashAccountRepository CashAccounts { get; }
    ICashTransactionRepository CashTransactions { get; }
    
    Task<int> SaveChangesAsync();
    Task BeginTransactionAsync();
    Task CommitTransactionAsync();
    Task RollbackTransactionAsync();
}

