using SSFinapp.Data.Repositories;
using SSFinapp.Domain.Entities;
using SSFinapp.Domain.Exceptions;
using SSFinapp.Domain.Validation;

namespace SSFinapp.Business.Services;

/// <summary>
/// Cari hesap yönetimi servisi implementation
/// </summary>
public class CurrentAccountService : ICurrentAccountService
{
    private readonly ICustomerRepository _customerRepository;
    private readonly ICurrentAccountTransactionRepository _currentAccountTransactionRepository;
    
    public CurrentAccountService(
        ICustomerRepository customerRepository,
        ICurrentAccountTransactionRepository currentAccountTransactionRepository)
    {
        _customerRepository = customerRepository;
        _currentAccountTransactionRepository = currentAccountTransactionRepository;
    }
    
    // Customer operations
    public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
    {
        return await _customerRepository.GetAllAsync();
    }
    
    public async Task<IEnumerable<Customer>> GetActiveCustomersAsync()
    {
        return await _customerRepository.GetActiveCustomersAsync();
    }
    
    public async Task<Customer?> GetCustomerByIdAsync(int id)
    {
        return await _customerRepository.GetByIdAsync(id);
    }
    
    public async Task<Customer> AddCustomerAsync(Customer customer)
    {
        // Validasyon
        if (!ValidationHelper.IsValidString(customer.Ad, 200))
            throw new ValidationException("Müşteri adı geçersiz veya çok uzun!");
            
        if (!ValidationHelper.IsValidEmail(customer.Email))
            throw new ValidationException("Email formatı geçersiz!");
            
        if (!ValidationHelper.IsValidPhone(customer.Telefon))
            throw new ValidationException("Telefon numarası geçersiz! Format: 05XX XXX XX XX");
            
        // Telefon formatla
        customer.Telefon = ValidationHelper.FormatPhone(customer.Telefon);
        
        return await _customerRepository.AddAsync(customer);
    }
    
    public async Task UpdateCustomerAsync(Customer customer)
    {
        // Validasyon
        if (!ValidationHelper.IsValidEmail(customer.Email))
            throw new ValidationException("Email formatı geçersiz!");
            
        if (!ValidationHelper.IsValidPhone(customer.Telefon))
            throw new ValidationException("Telefon numarası geçersiz!");
            
        customer.Telefon = ValidationHelper.FormatPhone(customer.Telefon);
        customer.GuncellemeTarihi = DateTime.Now;
        customer.GuncelleyenKullanici = "System";
        
        await _customerRepository.UpdateAsync(customer);
    }
    
    public async Task DeleteCustomerAsync(int id)
    {
        // Cari işlem kontrolü
        var transactions = await _currentAccountTransactionRepository.GetTransactionsByCustomerIdAsync(id);
        if (transactions.Any())
        {
            throw new CannotDeleteException("Müşteri", "Bu müşterinin cari işlemleri var!");
        }
        
        // Fiziksel silme (hard delete)
        await _customerRepository.DeleteAsync(id);
    }
    
    // Current account transaction operations
    public async Task<IEnumerable<CurrentAccountTransaction>> GetAllTransactionsAsync()
    {
        return await _currentAccountTransactionRepository.GetAllAsync();
    }
    
    public async Task<IEnumerable<CurrentAccountTransaction>> GetTransactionsByCustomerIdAsync(int customerId)
    {
        return await _currentAccountTransactionRepository.GetTransactionsByCustomerIdAsync(customerId);
    }
    
    public async Task<CurrentAccountTransaction> AddTransactionAsync(CurrentAccountTransaction transaction)
    {
        // Validasyon
        if (!ValidationHelper.IsNonNegativeNumber(transaction.Tutar))
            throw new ValidationException("Tutar negatif olamaz!");
            
        if (!ValidationHelper.IsNonNegativeNumber(transaction.Alinan))
            throw new ValidationException("Alınan miktar negatif olamaz!");
            
        if (!ValidationHelper.IsNonNegativeNumber(transaction.Verilen))
            throw new ValidationException("Verilen miktar negatif olamaz!");
        
        return await _currentAccountTransactionRepository.AddAsync(transaction);
    }
    
    public async Task UpdateTransactionAsync(CurrentAccountTransaction transaction)
    {
        await _currentAccountTransactionRepository.UpdateAsync(transaction);
    }
    
    public async Task DeleteTransactionAsync(int id)
    {
        await _currentAccountTransactionRepository.DeleteAsync(id);
    }
    
    // Balance calculations
    public async Task<decimal> GetCustomerBalanceAsync(int customerId)
    {
        return await _currentAccountTransactionRepository.GetCustomerBalanceAsync(customerId);
    }
    
    public async Task<Dictionary<int, decimal>> GetAllCustomerBalancesAsync()
    {
        var customers = await _customerRepository.GetAllAsync();
        var balances = new Dictionary<int, decimal>();
        
        foreach (var customer in customers)
        {
            var balance = await GetCustomerBalanceAsync(customer.Id);
            balances[customer.Id] = balance;
        }
        
        return balances;
    }
    
    // Dashboard statistics
    public async Task<decimal> GetTotalCollectionsThisMonthAsync()
    {
        var startOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        var endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
        
        var transactions = await _currentAccountTransactionRepository.GetAllAsync();
        return transactions
            .Where(t => t.Tarih >= startOfMonth && t.Tarih <= endOfMonth && t.Alinan > 0)
            .Sum(t => t.Alinan);
    }
    
    public async Task<int> GetOverdueReceivablesCountAsync()
    {
        var balances = await GetAllCustomerBalancesAsync();
        // Bakiye > 0 olan müşteriler (bizim alacaklarımız)
        return balances.Count(b => b.Value > 0);
    }
    
    public async Task<decimal> GetTotalOverdueReceivablesAsync()
    {
        var balances = await GetAllCustomerBalancesAsync();
        // Toplam alacaklarımız
        return balances.Where(b => b.Value > 0).Sum(b => b.Value);
    }
}

