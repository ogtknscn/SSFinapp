namespace SSFinapp.Domain.Exceptions;

/// <summary>
/// İş mantığı hataları için özel exception
/// </summary>
public class BusinessException : Exception
{
    public BusinessException(string message) : base(message)
    {
    }
    
    public BusinessException(string message, Exception innerException) 
        : base(message, innerException)
    {
    }
}

/// <summary>
/// Validasyon hataları
/// </summary>
public class ValidationException : BusinessException
{
    public ValidationException(string message) : base(message)
    {
    }
}

/// <summary>
/// Yetersiz stok hatası
/// </summary>
public class InsufficientStockException : BusinessException
{
    public decimal RequiredAmount { get; }
    public decimal AvailableAmount { get; }
    
    public InsufficientStockException(decimal required, decimal available) 
        : base($"Yetersiz stok! Gerekli: {required}, Mevcut: {available}")
    {
        RequiredAmount = required;
        AvailableAmount = available;
    }
}

/// <summary>
/// Kayıt silinemez hatası
/// </summary>
public class CannotDeleteException : BusinessException
{
    public CannotDeleteException(string entityName, string reason) 
        : base($"{entityName} silinemez: {reason}")
    {
    }
}

