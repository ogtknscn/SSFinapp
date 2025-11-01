namespace SSFinapp.Domain.Entities;

/// <summary>
/// Tüm entity'ler için temel sınıf
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// Benzersiz kimlik
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Kayıt oluşturma tarihi
    /// </summary>
    public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    
    /// <summary>
    /// Kayıt oluşturan kullanıcı (Audit Trail)
    /// </summary>
    public string OlusturanKullanici { get; set; } = "System";
    
    /// <summary>
    /// Son güncelleme tarihi (Audit Trail)
    /// </summary>
    public DateTime? GuncellemeTarihi { get; set; }
    
    /// <summary>
    /// Güncelleyen kullanıcı (Audit Trail)
    /// </summary>
    public string? GuncelleyenKullanici { get; set; }
}

