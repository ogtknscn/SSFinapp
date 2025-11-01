using SSFinapp.Domain.Enums;

namespace SSFinapp.Domain.Entities;

/// <summary>
/// Cari hesap işlemlerini temsil eder
/// </summary>
public class CurrentAccountTransaction : BaseEntity
{
    /// <summary>
    /// İlgili müşteri ID
    /// </summary>
    public int MusteriId { get; set; }
    
    /// <summary>
    /// İlgili müşteri
    /// </summary>
    public virtual Customer? Musteri { get; set; }
    
    /// <summary>
    /// İşlem tarihi
    /// </summary>
    public DateTime Tarih { get; set; } = DateTime.Now;
    
    /// <summary>
    /// Malzeme/Ürün açıklaması
    /// </summary>
    public string? Malzeme { get; set; }
    
    /// <summary>
    /// İşlem tutarı
    /// </summary>
    public decimal Tutar { get; set; }
    
    /// <summary>
    /// Müşteriden alınan miktar
    /// </summary>
    public decimal Alinan { get; set; } = 0;
    
    /// <summary>
    /// Müşteriye verilen miktar
    /// </summary>
    public decimal Verilen { get; set; } = 0;
    
    /// <summary>
    /// İşlem tipi (Para, Mal)
    /// </summary>
    public PaymentType IslemTipi { get; set; } = PaymentType.Para;
    
    /// <summary>
    /// İşlem açıklaması
    /// </summary>
    public string? Aciklama { get; set; }
}

