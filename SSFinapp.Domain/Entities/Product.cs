namespace SSFinapp.Domain.Entities;

/// <summary>
/// Ürün bilgilerini temsil eder
/// </summary>
public class Product : BaseEntity
{
    /// <summary>
    /// Ürün adı
    /// </summary>
    public string Ad { get; set; } = string.Empty;
    
    /// <summary>
    /// Birim (Adet, kg, m³, vb.)
    /// </summary>
    public string Birim { get; set; } = "Adet";
    
    /// <summary>
    /// Ürünün aktif olup olmadığı
    /// </summary>
    public bool Aktif { get; set; } = true;
    
    /// <summary>
    /// Bu ürüne ait stok hareketleri
    /// </summary>
    public virtual ICollection<StockTransaction> StokHareketleri { get; set; } = new List<StockTransaction>();
}

