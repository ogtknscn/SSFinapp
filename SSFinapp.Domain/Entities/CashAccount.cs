namespace SSFinapp.Domain.Entities;

/// <summary>
/// Kasa hesabını temsil eder
/// </summary>
public class CashAccount : BaseEntity
{
    /// <summary>
    /// Kasa adı
    /// </summary>
    public string Ad { get; set; } = string.Empty;
    
    /// <summary>
    /// Para birimi (TRY, USD, EUR, vb.)
    /// </summary>
    public string ParaBirimi { get; set; } = "TRY";
    
    /// <summary>
    /// Kasa açıklaması
    /// </summary>
    public string? Aciklama { get; set; }
    
    /// <summary>
    /// Kasanın aktif olup olmadığı
    /// </summary>
    public bool Aktif { get; set; } = true;
    
    /// <summary>
    /// Bu kasaya ait işlemler
    /// </summary>
    public virtual ICollection<CashTransaction> Islemler { get; set; } = new List<CashTransaction>();
}

