using SSFinapp.Domain.Entities;

namespace SSFinapp.Business.Services;

/// <summary>
/// Cari hesap yönetimi servisi interface
/// </summary>
public interface ICurrentAccountService
{
    // Customer operations
    Task<IEnumerable<Customer>> GetAllCustomersAsync();
    Task<IEnumerable<Customer>> GetActiveCustomersAsync();
    Task<Customer?> GetCustomerByIdAsync(int id);
    Task<Customer> AddCustomerAsync(Customer customer);
    Task UpdateCustomerAsync(Customer customer);
    Task DeleteCustomerAsync(int id);
    
    // Current account transaction operations
    Task<IEnumerable<CurrentAccountTransaction>> GetAllTransactionsAsync();
    Task<IEnumerable<CurrentAccountTransaction>> GetTransactionsByCustomerIdAsync(int customerId);
    Task<CurrentAccountTransaction> AddTransactionAsync(CurrentAccountTransaction transaction);
    Task UpdateTransactionAsync(CurrentAccountTransaction transaction);
    Task DeleteTransactionAsync(int id);
    
    // Balance calculations
    Task<decimal> GetCustomerBalanceAsync(int customerId);
    Task<Dictionary<int, decimal>> GetAllCustomerBalancesAsync();
}

