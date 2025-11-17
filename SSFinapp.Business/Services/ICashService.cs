using SSFinapp.Domain.Entities;

namespace SSFinapp.Business.Services;

public interface ICashService
{
    // CashAccount operations
    Task<IEnumerable<CashAccount>> GetAllCashAccountsAsync();
    Task<IEnumerable<CashAccount>> GetActiveCashAccountsAsync();
    Task<CashAccount?> GetCashAccountByIdAsync(int id);
    Task<CashAccount> AddCashAccountAsync(CashAccount account);
    Task UpdateCashAccountAsync(CashAccount account);
    Task DeleteCashAccountAsync(int id);
    
    // CashTransaction operations
    Task<IEnumerable<CashTransaction>> GetAllTransactionsAsync();
    Task<IEnumerable<CashTransaction>> GetTransactionsByCashAccountIdAsync(int cashAccountId);
    Task<CashTransaction> AddTransactionAsync(CashTransaction transaction);
    Task UpdateTransactionAsync(CashTransaction transaction);
    Task DeleteTransactionAsync(int id);
    
    // Balance calculations
    Task<decimal> GetCashAccountBalanceAsync(int cashAccountId);
    Task<Dictionary<int, decimal>> GetAllCashAccountBalancesAsync();
}

