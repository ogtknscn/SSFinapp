# 💼 S&S Finans Uygulaması

![Version](https://img.shields.io/badge/version-0.0.1-blue.svg)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey.svg)
![.NET](https://img.shields.io/badge/.NET-8.0-purple.svg)
![License](https://img.shields.io/badge/license-MIT-green.svg)

On-premise çalışan, kullanıcı dostu bir finans ve stok yönetim uygulaması. Tamamen yerel (offline) çalışır, internet bağlantısı gerektirmez.

## 🎯 Özellikler

### ✅ Stok Yönetimi
- ✅ Ürün ekleme, düzenleme, silme
- ✅ Stok giriş/çıkış işlemleri
- ✅ Anlık stok seviyesi görüntüleme
- ✅ Negatif stok kontrolü
- ✅ Ürün bazlı stok hareketleri

### 👥 Müşteri & Cari Hesap
- ✅ Müşteri yönetimi (CRUD)
- ✅ İletişim bilgileri yönetimi
- ✅ Otomatik telefon formatlaması
- ✅ Para ve mal bazlı cari işlemler
- ✅ Bakiye hesaplama ve takibi
- ✅ Vadesi geçen alacaklar takibi
- ✅ Aylık tahsilat özeti

### 💰 Kasa Yönetimi
- ✅ Kasa hesabı yönetimi
- ✅ Kasa giriş/çıkış işlemleri
- ✅ Kasa transfer işlemleri
- ✅ Kasa bakiye hesaplama
- ✅ Çoklu kasa desteği
- ✅ Para birimi desteği (TRY, USD, EUR, vb.)

### 🎨 Modern UI/UX
- ✅ MaterialSkin.2 modern UI framework
- ✅ Dark Mode / Light Mode desteği
- ✅ Dashboard widget'ları (Tahsilatlar, Vadesi Geçen Alacaklar, Kritik Stok, Kasa Bakiyeleri)
- ✅ Klavye kısayolları (INS, DEL, F5, F3, ESC, ENTER)
- ✅ In-line entity creation (hızlı ürün/müşteri ekleme)
- ✅ Ayarlar formu

### 📊 Raporlama & Export
- ✅ Excel'e aktarma (tüm modüller)
- ✅ Veritabanı yedekleme
- ✅ Veritabanı geri yükleme
- ✅ Dashboard istatistikleri

### 🔒 Güvenlik & Validasyon
- ✅ Input validasyonu
- ✅ Business rule kontrolü
- ✅ Bağımlılık kontrolü (cascade delete protection)
- ✅ Hata yönetimi

## 📥 Hızlı Başlangıç

### Son Sürümü İndirin
1. [Releases](../../releases) sayfasına gidin
2. **SSFinapp-v0.0.1-win-x64.zip** dosyasını indirin
3. ZIP'i ayıklayın ve **SSFinapp.UI.exe** çalıştırın
4. Hiçbir ek yazılım gerekmez! 🎉

### Detaylı Kurulum
Detaylı kurulum talimatları için [INSTALLATION.md](INSTALLATION.md) dosyasına bakın.

## 🚧 Gelecek Özellikler (Roadmap)

### v0.1.0 - İyileştirmeler (Tamamlandı ✅)
- ✅ Dashboard/Özet görünümü
- ✅ Modern tema (MaterialSkin.2)
- ✅ Dark mode desteği
- ✅ Keyboard shortcuts
- ✅ Dashboard widget'ları
- ✅ In-line entity creation

### v0.1.1 - Gelecek İyileştirmeler
- [ ] Gelişmiş filtreleme ve arama
- [ ] Tarih aralığı filtreleri
- [ ] Grafiksel raporlar
- [ ] Düşük stok uyarıları
- [ ] Kasa hesabı yönetim formu

### v0.2.0 - Kullanıcı Yönetimi
- [ ] Kullanıcı sistemi
- [ ] Authentication
- [ ] Rol bazlı yetkilendirme
- [ ] Kullanıcı bazlı audit trail

## 🛠 Teknoloji Stack

- **Framework**: .NET 8.0 (LTS)
- **UI**: Windows Forms + MaterialSkin.2
- **Veritabanı**: SQLite 3.x
- **ORM**: Entity Framework Core 8.0
- **Mimari**: Clean Architecture (Basitleştirilmiş)
- **DI**: Microsoft.Extensions.DependencyInjection
- **Export**: ClosedXML (Excel export)

## 📁 Proje Yapısı

```
SSFinapp/
├── SSFinapp.Domain/          # Entity modelleri ve Enum'lar
│   ├── Entities/
│   │   ├── BaseEntity.cs
│   │   ├── Product.cs
│   │   ├── StockTransaction.cs
│   │   ├── Customer.cs
│   │   ├── CurrentAccountTransaction.cs
│   │   ├── CashAccount.cs
│   │   └── CashTransaction.cs
│   └── Enums/
│       ├── TransactionType.cs
│       ├── PaymentType.cs
│       ├── CashTransactionType.cs
│       └── AccountType.cs
├── SSFinapp.Data/            # Data Access Layer
│   ├── ApplicationDbContext.cs
│   ├── DesignTimeDbContextFactory.cs
│   ├── Repositories/
│   │   ├── IRepository.cs
│   │   ├── GenericRepository.cs
│   │   ├── ProductRepository.cs
│   │   ├── StockTransactionRepository.cs
│   │   ├── CustomerRepository.cs
│   │   ├── CurrentAccountTransactionRepository.cs
│   │   ├── CashAccountRepository.cs
│   │   └── CashTransactionRepository.cs
│   └── Migrations/
├── SSFinapp.Business/        # Business Logic Layer
│   └── Services/
│       ├── IStockService.cs
│       ├── StockService.cs
│       ├── ICurrentAccountService.cs
│       ├── CurrentAccountService.cs
│       ├── ICashService.cs
│       ├── CashService.cs
│       ├── IExportService.cs
│       ├── ExportService.cs
│       ├── IBackupService.cs
│       └── BackupService.cs
└── SSFinapp.UI/              # Presentation Layer
    ├── Forms/
    │   ├── MainForm.cs
    │   ├── ProductManagementForm.cs
    │   ├── StockTransactionForm.cs
    │   ├── CustomerManagementForm.cs
    │   ├── CurrentAccountForm.cs
    │   ├── CashManagementForm.cs
    │   └── SettingsForm.cs
    ├── Helpers/
    │   ├── KeyboardHelper.cs
    │   ├── ThemeHelper.cs
    │   └── UIHelper.cs
    └── Program.cs
```

## 🗄 Veritabanı Şeması

### Products (Ürünler)
- `Id` - Primary Key
- `Ad` - Ürün adı (Required)
- `Birim` - Birim (Adet, kg, m³, vb.)
- `Aktif` - Aktiflik durumu
- `OlusturmaTarihi` - Oluşturma tarihi

### StockTransactions (Stok Hareketleri)
- `Id` - Primary Key
- `Tarih` - İşlem tarihi
- `IslemTipi` - Giriş/Çıkış
- `UrunId` - Foreign Key → Products
- `Miktar` - Miktar
- `Birim` - Birim
- `Aciklama` - Açıklama
- `OlusturmaTarihi` - Oluşturma tarihi

### Customers (Müşteriler)
- `Id` - Primary Key
- `Ad` - Müşteri adı (Required)
- `Telefon` - Telefon numarası
- `Email` - Email adresi
- `Adres` - Adres
- `Aktif` - Aktiflik durumu
- `OlusturmaTarihi` - Oluşturma tarihi

### CurrentAccountTransactions (Cari Hareketler)
- `Id` - Primary Key
- `MusteriId` - Foreign Key → Customers
- `Tarih` - İşlem tarihi
- `Malzeme` - Malzeme/Açıklama
- `Tutar` - İşlem tutarı
- `Alinan` - Alınan miktar
- `Verilen` - Verilen miktar
- `IslemTipi` - Para/Mal
- `Aciklama` - Açıklama
- `OlusturmaTarihi` - Oluşturma tarihi

### CashAccounts (Kasa Hesapları)
- `Id` - Primary Key
- `Ad` - Kasa adı (Required)
- `ParaBirimi` - Para birimi (TRY, USD, EUR, vb.)
- `Aciklama` - Açıklama
- `Aktif` - Aktiflik durumu
- `OlusturmaTarihi` - Oluşturma tarihi

### CashTransactions (Kasa İşlemleri)
- `Id` - Primary Key
- `KasaId` - Foreign Key → CashAccounts
- `Tarih` - İşlem tarihi
- `IslemTipi` - Giriş/Çıkış/Transfer
- `Tutar` - İşlem tutarı
- `Aciklama` - Açıklama
- `HedefHesapId` - Transfer için hedef hesap ID
- `HedefHesapTipi` - Transfer için hedef hesap tipi
- `OlusturmaTarihi` - Oluşturma tarihi

## 🚀 Kurulum ve Çalıştırma

### Gereksinimler
- .NET 8.0 SDK veya üzeri
- Windows işletim sistemi

### Adımlar

1. **Projeyi Klonlayın**
```bash
cd "S&S Finapp"
```

2. **Bağımlılıkları Yükleyin**
```bash
dotnet restore
```

3. **Veritabanını Oluşturun**
```bash
dotnet ef database update --project SSFinapp.Data
```

4. **Uygulamayı Çalıştırın**
```bash
dotnet run --project SSFinapp.UI
```

Veya Visual Studio'da `SSFinapp.UI` projesini başlatın.

## 📊 Kullanım

### İlk Çalıştırma
Uygulama ilk çalıştırıldığında:
1. SQLite veritabanı (`ssfinapp.db`) otomatik oluşturulur
2. Migration'lar otomatik çalıştırılır
3. Ana dashboard açılır

### Ana Dashboard
- Toplam ürün sayısını gösterir
- Toplam müşteri sayısını gösterir
- **Widget'lar:**
  - 📊 Bu Ay Tahsilatlar
  - ⚠️ Vadesi Geçen Alacaklar
  - 📦 Kritik Stok
  - 💰 Kasa Bakiyeleri
- Modüllere hızlı erişim butonları

### Modüller
- **Stok Yönetimi**: Ürün ve stok işlemleri
- **Cari Hesap**: Müşteri ve cari işlemler
- **Kasa Yönetimi**: Kasa hesapları ve işlemleri
- **Ürünler**: Ürün tanımları
- **Müşteriler**: Müşteri tanımları
- **Ayarlar**: Tema ayarları (Dark/Light Mode)

### Klavye Kısayolları
- **INS**: Yeni kayıt ekle
- **DEL**: Seçili kaydı sil
- **F5**: Listeyi yenile
- **F3**: Arama kutusuna odaklan
- **ENTER**: Form kaydet
- **ESC**: Formu kapat/iptal

## 🔧 Geliştirme

### Yeni Migration Ekleme
```bash
dotnet ef migrations add <MigrationName> --project SSFinapp.Data
```

### Migration Geri Alma
```bash
dotnet ef migrations remove --project SSFinapp.Data
```

### Build
```bash
dotnet build
```

### Test (İleride Eklenecek)
```bash
dotnet test
```

## 📝 Notlar

- Veritabanı dosyası (`ssfinapp.db`) proje dizininde oluşturulur
- Her çalıştırmada migration'lar otomatik kontrol edilir
- Dependency Injection kullanılarak loose coupling sağlanır
- Repository pattern ile data access katmanı izole edilmiş

## 🔒 Güvenlik

- Veritabanı dosyası yerel olarak saklanır
- Bağımlılık kontrolü (ilişkili kayıtlar silinemez)
- Input validasyonu
- Business rule kontrolü
- Yedekleme özelliği (manuel ve otomatik)

## 📸 Ekran Görüntüleri

*(Coming soon)*

## 🤝 Katkıda Bulunma

Katkılarınızı bekliyoruz! Lütfen:
1. Fork yapın
2. Feature branch oluşturun (`git checkout -b feature/amazing-feature`)
3. Commit yapın (`git commit -m 'Add some amazing feature'`)
4. Push yapın (`git push origin feature/amazing-feature`)
5. Pull Request açın

## 🐛 Hata Bildirimi

Bir hata buldunuz mu? [Issue açın](../../issues/new) ve bize bildirin!

## 📄 Lisans

Bu proje MIT lisansı altında dağıtılmaktadır. Detaylar için [LICENSE](LICENSE) dosyasına bakın.

## 👥 Geliştirici

**S&S Finans Ekibi**
- 📅 Tarih: 1 Kasım 2024
- 🎯 Version: 0.0.1

## 📚 Dokümantasyon

- [Kurulum Rehberi](INSTALLATION.md)
- [Release Notes](RELEASE_NOTES.md)
- [Proje Özeti](SUMMARY.md)
- [Planlama](PROJECT_PLAN.md)

## ⭐ Destek

Projeyi beğendiyseniz yıldız vermeyi unutmayın! ⭐

---

**Made with ❤️ by S&S Team**

