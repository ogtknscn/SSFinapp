namespace SSFinapp.Domain.Entities;

/// <summary>
/// Müşteri bilgilerini temsil eder
/// </summary>
public class Customer : BaseEntity
{
    /// <summary>
    /// Müşteri adı
    /// </summary>
    public string Ad { get; set; } = string.Empty;
    
    /// <summary>
    /// Telefon numarası
    /// </summary>
    public string? Telefon { get; set; }
    
    /// <summary>
    /// Email adresi
    /// </summary>
    public string? Email { get; set; }
    
    /// <summary>
    /// Adres bilgisi
    /// </summary>
    public string? Adres { get; set; }
    
    /// <summary>
    /// Müşterinin aktif olup olmadığı
    /// </summary>
    public bool Aktif { get; set; } = true;
    
    /// <summary>
    /// Bu müşteriye ait cari hareketler
    /// </summary>
    public virtual ICollection<CurrentAccountTransaction> CariHareketler { get; set; } = new List<CurrentAccountTransaction>();
}

