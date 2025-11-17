using SSFinapp.Domain.Enums;

namespace SSFinapp.Domain.Entities;

/// <summary>
/// Kasa işlemlerini temsil eder
/// </summary>
public class CashTransaction : BaseEntity
{
    /// <summary>
    /// İlgili kasa ID
    /// </summary>
    public int KasaId { get; set; }
    
    /// <summary>
    /// İlgili kasa
    /// </summary>
    public virtual CashAccount? Kasa { get; set; }
    
    /// <summary>
    /// İşlem tarihi
    /// </summary>
    public DateTime Tarih { get; set; } = DateTime.Now;
    
    /// <summary>
    /// İşlem tipi (Giriş, Çıkış, Transfer)
    /// </summary>
    public CashTransactionType IslemTipi { get; set; } = CashTransactionType.Giris;
    
    /// <summary>
    /// İşlem tutarı
    /// </summary>
    public decimal Tutar { get; set; }
    
    /// <summary>
    /// İşlem açıklaması
    /// </summary>
    public string? Aciklama { get; set; }
    
    /// <summary>
    /// Transfer işlemi ise hedef kasa/banka ID
    /// </summary>
    public int? HedefHesapId { get; set; }
    
    /// <summary>
    /// Transfer işlemi ise hedef hesap tipi
    /// </summary>
    public AccountType? HedefHesapTipi { get; set; }
}

