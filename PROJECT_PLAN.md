# S&S Finapp - Proje Planı

## 📋 Genel Bakış
On-premise çalışan, basit ve kullanıcı dostu bir finans/stok yönetim uygulaması. Excel'e dayalı mevcut sistemin dijitalleştirilmiş hali.

## 🎯 Temel Özellikler

### 1. Stok Yönetimi
- **Girdi/Çıktı İşlemleri**: Ürün giriş ve çıkış kayıtları
  - Tarih
  - Ürün adı
  - Miktar
  - Türü (Birim: Adet, kg, m³, vb.)
  - İşlem tipi (Giriş/Çıkış)

- **Anlık Stok**: 
  - Ürün bazlı mevcut stok seviyeleri
  - Giren toplam
  - Çıkan toplam
  - Net stok (Hesaplanan: Giren - Çıkan)

### 2. Cari İşlemler
- **Müşteri Yönetimi**: Her müşteri için ayrı hesap
- **İşlem Kayıtları**:
  - Tarih
  - Malzeme/Açıklama
  - Tutar (Amount)
  - Alınan (Received)
  - Verilen (Given)
  - Bakiye (Hesaplanan: Alınan - Verilen toplamı)
- **Ödeme Tipleri**: 
  - Para (Cash)
  - Mal (Material)

## 🛠 Teknoloji Stack

### Önerilen:
- **Platform**: .NET 8 (LTS) - Windows masaüstü uygulaması
- **UI Framework**: **ModernUI** veya **WinForms** (Basit ve hafif)
- **Veritabanı**: **SQLite** (Embedded, kolay dağıtım)
- **ORM**: **Entity Framework Core** (Code-First yaklaşımı)
- **Mimari**: Basit Repository Pattern
- **Serialization**: JSON (yedekleme için)

### Alternatif:
- **Platform**: .NET 8 WinForms Application
- **Veritabanı**: Microsoft SQL Server LocalDB (Daha fazla özellik)
- **ORM**: Dapper (Daha performanslı, daha az overhead)

## 🗄 Veritabanı Şema Tasarımı

### 1. Ürünler (Products)
```sql
Id: INT PRIMARY KEY
Ad: NVARCHAR(200) NOT NULL
Birim: NVARCHAR(50) -- (Adet, kg, m³, vb.)
Aktif: BIT DEFAULT 1
OlusturmaTarihi: DATETIME DEFAULT GETDATE()
```

### 2. Stok Hareketleri (StockTransactions)
```sql
Id: INT PRIMARY KEY
Tarih: DATETIME NOT NULL
IslemTipi: NVARCHAR(10) NOT NULL -- (Giriş/Çıkış)
UrunId: INT NOT NULL FOREIGN KEY → Products
Miktar: DECIMAL(18,2) NOT NULL
Birim: NVARCHAR(50)
Aciklama: NVARCHAR(500)
OlusturmaTarihi: DATETIME DEFAULT GETDATE()
```

### 3. Müşteriler (Customers)
```sql
Id: INT PRIMARY KEY
Ad: NVARCHAR(200) NOT NULL
Telefon: NVARCHAR(20)
Email: NVARCHAR(100)
Adres: NVARCHAR(500)
Aktif: BIT DEFAULT 1
OlusturmaTarihi: DATETIME DEFAULT GETDATE()
```

### 4. Cari Hareketler (CurrentAccountTransactions)
```sql
Id: INT PRIMARY KEY
MusteriId: INT NOT NULL FOREIGN KEY → Customers
Tarih: DATETIME NOT NULL
Malzeme: NVARCHAR(500) -- Açıklama
Tutar: DECIMAL(18,2) NOT NULL
Alinan: DECIMAL(18,2) DEFAULT 0
Verilen: DECIMAL(18,2) DEFAULT 0
IslemTipi: NVARCHAR(20) -- (Para, Mal, vb.)
Aciklama: NVARCHAR(500)
OlusturmaTarihi: DATETIME DEFAULT GETDATE()
```

## 📐 Uygulama Yapısı

### Klasör Düzeni (Clean Architecture - Basitleştirilmiş)
```
S&S.Finapp/
├── S&S.Finapp.Domain/
│   ├── Entities/
│   │   ├── Product.cs
│   │   ├── StockTransaction.cs
│   │   ├── Customer.cs
│   │   └── CurrentAccountTransaction.cs
│   └── Enums/
│       ├── TransactionType.cs
│       └── PaymentType.cs
├── S&S.Finapp.Data/
│   ├── ApplicationDbContext.cs
│   ├── Repositories/
│   │   ├── IRepository.cs
│   │   ├── GenericRepository.cs
│   │   ├── IProductRepository.cs
│   │   ├── ICustomerRepository.cs
│   │   └── ...
│   └── Migrations/
├── S&S.Finapp.Business/
│   ├── Services/
│   │   ├── IStockService.cs
│   │   ├── StockService.cs
│   │   ├── ICurrentAccountService.cs
│   │   └── CurrentAccountService.cs
│   └── ViewModels/
│       ├── StockTransactionViewModel.cs
│       └── CurrentAccountViewModel.cs
├── S&S.Finapp.UI/
│   ├── Forms/
│   │   ├── MainForm.cs
│   │   ├── StockManagerForm.cs
│   │   ├── CurrentAccountForm.cs
│   │   ├── CustomerForm.cs
│   │   └── ProductForm.cs
│   ├── Controls/
│   └── Resources/
└── S&S.Finapp.UI.csproj
```

### Ana Formlar
1. **Ana Form (Dashboard)**: Menü ve navigasyon
2. **Stok Yönetimi Formu**: İşlem girişi ve anlık stok görüntüleme
3. **Cari Hesap Formu**: Müşteri bazlı işlem takibi
4. **Ürün Yönetimi Formu**: Ürün ekleme/düzenleme
5. **Müşteri Yönetimi Formu**: Müşteri ekleme/düzenleme

## 🎨 UI Tasarım Prensipleri

### Temel İlkeler
- **Basitlik**: Karmaşık olmasın, sade işlevsel
- **Hızlı Erişim**: Sık kullanılan işlemler için kısayollar
- **Veri Görselleştirme**: Tablo görünümleri (Excel benzeri)
- **Renk Kodlama**: 
  - Ödeme işlemleri: Kırmızı
  - Yeni girişler: Sarı
  - Normal işlemler: Beyaz

### Modern UI Önerileri
- WinUI 3 veya ModernUI kütüphanesi
- Flat design
- Yumuşak renk paleti
- Responsive grid layout

## 🔐 Güvenlik ve Veri Yönetimi

### Güvenlik
- Veritabanı şifreleme (SQLite için AES-256)
- Veri doğrulama (input validation)
- Transaction management (veri bütünlüğü)

### Yedekleme
- Manuel yedek alma (File > Backup)
- Otomatik yedekleme (Aylık)
- Geri yükleme (File > Restore)
- Excel export (mevcut sistemle uyumluluk)

## 📊 Raporlama (İleri Aşama)

### Temel Raporlar
1. Stok Raporu: Ürün bazlı hareket özeti
2. Cari Hesap Özeti: Müşteri bakiyeleri
3. Günlük/Haftalık/Aylık işlem özeti
4. Excel export

## 🚀 Geliştirme Aşamaları

### Faz 1: Temel Altyapı (1-2 hafta)
- [ ] Proje yapısını oluştur
- [ ] Veritabanı şemasını kur
- [ ] Entity modellerini oluştur
- [ ] Repository pattern implementasyonu
- [ ] EF Core migration

### Faz 2: Stok Modülü (1 hafta)
- [ ] Ürün yönetimi formu
- [ ] Stok hareketi girişi formu
- [ ] Anlık stok görüntüleme
- [ ] Temel validasyon

### Faz 3: Cari Hesap Modülü (1 hafta)
- [ ] Müşteri yönetimi formu
- [ ] Cari işlem girişi formu
- [ ] Müşteri hesap özeti
- [ ] Bakiye hesaplama

### Faz 4: UI İyileştirme (1 hafta)
- [ ] Modern UI tasarım
- [ ] Renk kodlama
- [ ] Keyboard shortcuts
- [ ] Form navigasyonu

### Faz 5: Yedekleme ve Export (3-4 gün)
- [ ] Veritabanı yedek alma
- [ ] Excel export
- [ ] Geri yükleme

### Faz 6: Test ve İyileştirme (1 hafta)
- [ ] Unit testler
- [ ] Integration testler
- [ ] Kullanıcı testi
- [ ] Bug fix

## 📝 Notlar ve Kararlar

### Kararlar
1. **SQLite seçimi**: Dağıtım kolaylığı, embedded DB
2. **WinForms**: Basit UI framework, hızlı geliştirme
3. **EF Core Code-First**: Veritabanı yönetim kolaylığı
4. **Repository Pattern**: Kod organizasyonu, test edilebilirlik

### Kaçınılacaklar (Şimdilik)
- Kullanıcı yetkilendirme/authentication (tek kullanıcı)
- Web servisleri/cloud entegrasyonu
- Gelişmiş raporlama motoru
- Çok dilli destek
- Barcode/QR okuma

### İleriye Dönük Olası Özellikler
- Dashboard/analytics
- KDV ve fatura yönetimi
- Email bildirimleri
- Mobil companion app
- Cloud sync

## 🔧 Teknoloji Versiyonları

- .NET 8.0 (LTS)
- Entity Framework Core 8.0
- SQLite 3.x
- ModernUI veya WinForms

## 📞 Sonuç

Bu plan, basit ve etkili bir finans/stok yönetim uygulaması için gereken tüm temel bileşenleri içeriyor. Excel tabanlı mevcut sistemin modern, dijital bir versiyonu olacak ve on-premise çalışacak şekilde tasarlanmış.

**Öncelik**: Basitlik ve güvenilirlik
**Hedef**: Kullanıcı dostu, performanslı, bakımı kolay uygulama
