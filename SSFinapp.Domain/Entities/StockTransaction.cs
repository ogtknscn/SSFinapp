using SSFinapp.Domain.Enums;

namespace SSFinapp.Domain.Entities;

/// <summary>
/// Stok giriş/çıkış işlemlerini temsil eder
/// </summary>
public class StockTransaction : BaseEntity
{
    /// <summary>
    /// İşlem tarihi
    /// </summary>
    public DateTime Tarih { get; set; } = DateTime.Now;
    
    /// <summary>
    /// İşlem tipi (Giriş/Çıkış)
    /// </summary>
    public TransactionType IslemTipi { get; set; }
    
    /// <summary>
    /// İlgili ürün ID
    /// </summary>
    public int UrunId { get; set; }
    
    /// <summary>
    /// İlgili ürün
    /// </summary>
    public virtual Product? Urun { get; set; }
    
    /// <summary>
    /// Miktar
    /// </summary>
    public decimal Miktar { get; set; }
    
    /// <summary>
    /// Birim (Adet, kg, m³, vb.)
    /// </summary>
    public string Birim { get; set; } = string.Empty;
    
    /// <summary>
    /// İşlem açıklaması
    /// </summary>
    public string? Aciklama { get; set; }
}

