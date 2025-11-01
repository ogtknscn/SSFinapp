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

### 📊 Raporlama & Export
- ✅ Excel'e aktarma (tüm modüller)
- ✅ Veritabanı yedekleme
- ✅ Veritabanı geri yükleme

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

### v0.1.0 - İyileştirmeler
- [ ] Dashboard/Özet görünümü
- [ ] Gelişmiş filtreleme ve arama
- [ ] Tarih aralığı filtreleri
- [ ] Grafiksel raporlar
- [ ] Düşük stok uyarıları

### v0.2.0 - Kullanıcı Yönetimi
- [ ] Kullanıcı sistemi
- [ ] Authentication
- [ ] Rol bazlı yetkilendirme
- [ ] Kullanıcı bazlı audit trail

### v0.3.0 - UI/UX İyileştirmeleri
- [ ] Modern tema
- [ ] Dark mode desteği
- [ ] Keyboard shortcuts
- [ ] Gelişmiş grid özellikleri

## 🛠 Teknoloji Stack

- **Framework**: .NET 8.0
- **UI**: Windows Forms
- **Veritabanı**: SQLite 3.x
- **ORM**: Entity Framework Core 9.0
- **Mimari**: Clean Architecture (Basitleştirilmiş)
- **DI**: Microsoft.Extensions.DependencyInjection

## 📁 Proje Yapısı

```
SSFinapp/
├── SSFinapp.Domain/          # Entity modelleri ve Enum'lar
│   ├── Entities/
│   │   ├── BaseEntity.cs
│   │   ├── Product.cs
│   │   ├── StockTransaction.cs
│   │   ├── Customer.cs
│   │   └── CurrentAccountTransaction.cs
│   └── Enums/
│       ├── TransactionType.cs
│       └── PaymentType.cs
├── SSFinapp.Data/            # Data Access Layer
│   ├── ApplicationDbContext.cs
│   ├── DesignTimeDbContextFactory.cs
│   ├── Repositories/
│   │   ├── IRepository.cs
│   │   ├── GenericRepository.cs
│   │   ├── ProductRepository.cs
│   │   ├── StockTransactionRepository.cs
│   │   ├── CustomerRepository.cs
│   │   └── CurrentAccountTransactionRepository.cs
│   └── Migrations/
├── SSFinapp.Business/        # Business Logic Layer
│   └── Services/
│       ├── IStockService.cs
│       ├── StockService.cs
│       ├── ICurrentAccountService.cs
│       └── CurrentAccountService.cs
└── SSFinapp.UI/              # Presentation Layer
    ├── Forms/
    │   └── MainForm.cs
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
- Modüllere hızlı erişim butonları

### Modüller (Yapım Aşamasında)
- **Stok Yönetimi**: Ürün ve stok işlemleri
- **Cari Hesap**: Müşteri ve cari işlemler
- **Ürünler**: Ürün tanımları
- **Müşteriler**: Müşteri tanımları

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
- Şifreleme (ileride eklenecek)
- Yedekleme özelliği (ileride eklenecek)

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

