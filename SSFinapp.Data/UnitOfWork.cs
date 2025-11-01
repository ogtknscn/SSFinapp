using Microsoft.EntityFrameworkCore.Storage;
using SSFinapp.Data.Repositories;

namespace SSFinapp.Data;

/// <summary>
/// Unit of Work implementation
/// </summary>
public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    private IDbContextTransaction? _transaction;
    
    public IProductRepository Products { get; }
    public IStockTransactionRepository StockTransactions { get; }
    public ICustomerRepository Customers { get; }
    public ICurrentAccountTransactionRepository CurrentAccountTransactions { get; }
    
    public UnitOfWork(
        ApplicationDbContext context,
        IProductRepository productRepository,
        IStockTransactionRepository stockTransactionRepository,
        ICustomerRepository customerRepository,
        ICurrentAccountTransactionRepository currentAccountTransactionRepository)
    {
        _context = context;
        Products = productRepository;
        StockTransactions = stockTransactionRepository;
        Customers = customerRepository;
        CurrentAccountTransactions = currentAccountTransactionRepository;
    }
    
    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
    
    public async Task BeginTransactionAsync()
    {
        _transaction = await _context.Database.BeginTransactionAsync();
    }
    
    public async Task CommitTransactionAsync()
    {
        try
        {
            await _context.SaveChangesAsync();
            if (_transaction != null)
            {
                await _transaction.CommitAsync();
            }
        }
        catch
        {
            await RollbackTransactionAsync();
            throw;
        }
    }
    
    public async Task RollbackTransactionAsync()
    {
        if (_transaction != null)
        {
            await _transaction.RollbackAsync();
            await _transaction.DisposeAsync();
            _transaction = null;
        }
    }
    
    public void Dispose()
    {
        _transaction?.Dispose();
        _context.Dispose();
    }
}

