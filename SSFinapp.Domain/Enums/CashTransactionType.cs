namespace SSFinapp.Domain.Enums;

/// <summary>
/// Kasa işlem tipleri
/// </summary>
public enum CashTransactionType
{
    /// <summary>
    /// Kasa girişi (tahsilat)
    /// </summary>
    Giris = 1,
    
    /// <summary>
    /// Kasa çıkışı (ödeme)
    /// </summary>
    Cikis = 2,
    
    /// <summary>
    /// Kasa transferi (kasa-kasa veya kasa-banka)
    /// </summary>
    Transfer = 3
}

