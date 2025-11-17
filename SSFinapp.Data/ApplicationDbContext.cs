using Microsoft.EntityFrameworkCore;
using SSFinapp.Domain.Entities;

namespace SSFinapp.Data;

/// <summary>
/// Ana veritabanı context sınıfı
/// </summary>
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    /// <summary>
    /// Ürünler tablosu
    /// </summary>
    public DbSet<Product> Products { get; set; } = null!;
    
    /// <summary>
    /// Stok hareketleri tablosu
    /// </summary>
    public DbSet<StockTransaction> StockTransactions { get; set; } = null!;
    
    /// <summary>
    /// Müşteriler tablosu
    /// </summary>
    public DbSet<Customer> Customers { get; set; } = null!;
    
    /// <summary>
    /// Cari hesap hareketleri tablosu
    /// </summary>
    public DbSet<CurrentAccountTransaction> CurrentAccountTransactions { get; set; } = null!;
    
    /// <summary>
    /// Kasa hesapları tablosu
    /// </summary>
    public DbSet<CashAccount> CashAccounts { get; set; } = null!;
    
    /// <summary>
    /// Kasa işlemleri tablosu
    /// </summary>
    public DbSet<CashTransaction> CashTransactions { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Product configuration
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Ad).IsRequired().HasMaxLength(200);
            entity.Property(e => e.Birim).HasMaxLength(50);
            entity.Property(e => e.Aktif).HasDefaultValue(true);
            entity.Property(e => e.OlusturmaTarihi).HasDefaultValueSql("datetime('now')");
            
            entity.HasMany(e => e.StokHareketleri)
                  .WithOne(e => e.Urun)
                  .HasForeignKey(e => e.UrunId)
                  .OnDelete(DeleteBehavior.Restrict);
        });
        
        // StockTransaction configuration
        modelBuilder.Entity<StockTransaction>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Tarih).IsRequired();
            entity.Property(e => e.IslemTipi).IsRequired();
            entity.Property(e => e.Miktar).HasColumnType("decimal(18,2)").IsRequired();
            entity.Property(e => e.Birim).HasMaxLength(50);
            entity.Property(e => e.Aciklama).HasMaxLength(500);
            entity.Property(e => e.OlusturmaTarihi).HasDefaultValueSql("datetime('now')");
        });
        
        // Customer configuration
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Ad).IsRequired().HasMaxLength(200);
            entity.Property(e => e.Telefon).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Adres).HasMaxLength(500);
            entity.Property(e => e.Aktif).HasDefaultValue(true);
            entity.Property(e => e.OlusturmaTarihi).HasDefaultValueSql("datetime('now')");
            
            entity.HasMany(e => e.CariHareketler)
                  .WithOne(e => e.Musteri)
                  .HasForeignKey(e => e.MusteriId)
                  .OnDelete(DeleteBehavior.Restrict);
        });
        
        // CurrentAccountTransaction configuration
        modelBuilder.Entity<CurrentAccountTransaction>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Tarih).IsRequired();
            entity.Property(e => e.Malzeme).HasMaxLength(500);
            entity.Property(e => e.Tutar).HasColumnType("decimal(18,2)").IsRequired();
            entity.Property(e => e.Alinan).HasColumnType("decimal(18,2)").HasDefaultValue(0);
            entity.Property(e => e.Verilen).HasColumnType("decimal(18,2)").HasDefaultValue(0);
            entity.Property(e => e.IslemTipi).IsRequired();
            entity.Property(e => e.Aciklama).HasMaxLength(500);
            entity.Property(e => e.OlusturmaTarihi).HasDefaultValueSql("datetime('now')");
        });
        
        // CashAccount configuration
        modelBuilder.Entity<CashAccount>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Ad).IsRequired().HasMaxLength(200);
            entity.Property(e => e.ParaBirimi).HasMaxLength(10).HasDefaultValue("TRY");
            entity.Property(e => e.Aciklama).HasMaxLength(500);
            entity.Property(e => e.Aktif).HasDefaultValue(true);
            entity.Property(e => e.OlusturmaTarihi).HasDefaultValueSql("datetime('now')");
            
            entity.HasMany(e => e.Islemler)
                  .WithOne(e => e.Kasa)
                  .HasForeignKey(e => e.KasaId)
                  .OnDelete(DeleteBehavior.Restrict);
        });
        
        // CashTransaction configuration
        modelBuilder.Entity<CashTransaction>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Tarih).IsRequired();
            entity.Property(e => e.IslemTipi).IsRequired();
            entity.Property(e => e.Tutar).HasColumnType("decimal(18,2)").IsRequired();
            entity.Property(e => e.Aciklama).HasMaxLength(500);
            entity.Property(e => e.OlusturmaTarihi).HasDefaultValueSql("datetime('now')");
        });
    }
}

