using SSFinapp.Data.Repositories;
using SSFinapp.Domain.Entities;
using SSFinapp.Domain.Enums;
using SSFinapp.Domain.Exceptions;
using SSFinapp.Domain.Validation;

namespace SSFinapp.Business.Services;

public class CashService : ICashService
{
    private readonly ICashAccountRepository _cashAccountRepository;
    private readonly ICashTransactionRepository _cashTransactionRepository;
    
    public CashService(
        ICashAccountRepository cashAccountRepository,
        ICashTransactionRepository cashTransactionRepository)
    {
        _cashAccountRepository = cashAccountRepository;
        _cashTransactionRepository = cashTransactionRepository;
    }
    
    public async Task<IEnumerable<CashAccount>> GetAllCashAccountsAsync()
    {
        return await _cashAccountRepository.GetAllAsync();
    }
    
    public async Task<IEnumerable<CashAccount>> GetActiveCashAccountsAsync()
    {
        return await _cashAccountRepository.GetActiveAccountsAsync();
    }
    
    public async Task<CashAccount?> GetCashAccountByIdAsync(int id)
    {
        return await _cashAccountRepository.GetByIdAsync(id);
    }
    
    public async Task<CashAccount> AddCashAccountAsync(CashAccount account)
    {
        if (!ValidationHelper.IsValidString(account.Ad, 200))
            throw new ValidationException("Kasa adı geçersiz veya çok uzun!");
            
        return await _cashAccountRepository.AddAsync(account);
    }
    
    public async Task UpdateCashAccountAsync(CashAccount account)
    {
        account.GuncellemeTarihi = DateTime.Now;
        account.GuncelleyenKullanici = "System";
        await _cashAccountRepository.UpdateAsync(account);
    }
    
    public async Task DeleteCashAccountAsync(int id)
    {
        var transactions = await _cashTransactionRepository.GetTransactionsByCashAccountIdAsync(id);
        if (transactions.Any())
        {
            throw new CannotDeleteException("Kasa", "Bu kasanın işlemleri var!");
        }
        
        await _cashAccountRepository.DeleteAsync(id);
    }
    
    public async Task<IEnumerable<CashTransaction>> GetAllTransactionsAsync()
    {
        return await _cashTransactionRepository.GetAllAsync();
    }
    
    public async Task<IEnumerable<CashTransaction>> GetTransactionsByCashAccountIdAsync(int cashAccountId)
    {
        return await _cashTransactionRepository.GetTransactionsByCashAccountIdAsync(cashAccountId);
    }
    
    public async Task<CashTransaction> AddTransactionAsync(CashTransaction transaction)
    {
        if (!ValidationHelper.IsPositiveNumber(transaction.Tutar))
            throw new ValidationException("Tutar sıfırdan büyük olmalıdır!");
            
        return await _cashTransactionRepository.AddAsync(transaction);
    }
    
    public async Task UpdateTransactionAsync(CashTransaction transaction)
    {
        await _cashTransactionRepository.UpdateAsync(transaction);
    }
    
    public async Task DeleteTransactionAsync(int id)
    {
        await _cashTransactionRepository.DeleteAsync(id);
    }
    
    public async Task<decimal> GetCashAccountBalanceAsync(int cashAccountId)
    {
        return await _cashTransactionRepository.GetCashAccountBalanceAsync(cashAccountId);
    }
    
    public async Task<Dictionary<int, decimal>> GetAllCashAccountBalancesAsync()
    {
        var accounts = await _cashAccountRepository.GetAllAsync();
        var balances = new Dictionary<int, decimal>();
        
        foreach (var account in accounts)
        {
            var balance = await GetCashAccountBalanceAsync(account.Id);
            balances[account.Id] = balance;
        }
        
        return balances;
    }
}

