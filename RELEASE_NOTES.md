# 📋 Release Notes - v0.0.1

## 🎉 İlk Sürüm (First Release)
**Yayın Tarihi**: 1 Kasım 2024

### ✨ Özellikler

#### 📦 Stok Yönetimi
- ✅ Ürün ekleme, düzenleme, silme
- ✅ Stok giriş/çıkış işlemleri
- ✅ Anlık stok seviyesi görüntüleme
- ✅ Ürün bazlı stok hareketleri
- ✅ Negatif stok kontrolü
- ✅ Aktif/Pasif ürün durumu

#### 👥 Müşteri Yönetimi
- ✅ Müşteri ekleme, düzenleme, silme
- ✅ İletişim bilgileri (Telefon, Email, Adres)
- ✅ Otomatik telefon formatlaması (05XX XXX XX XX)
- ✅ Email formatı validasyonu
- ✅ Aktif/Pasif müşteri durumu

#### 💰 Cari Hesap Yönetimi
- ✅ Para ve Mal bazlı işlem kaydı
- ✅ Alınan/Verilen takibi
- ✅ Müşteri bazlı bakiye hesaplama
- ✅ İşlem detayları ve tarih takibi
- ✅ Müşteri bazlı işlem listeleme

#### 🔧 Teknik Özellikler
- ✅ SQLite veritabanı (yerleşik)
- ✅ Entity Framework Core (Code-First)
- ✅ Bağımlılık kontrolü (Cascade Delete Protection)
- ✅ Audit Trail (Oluşturma/Güncelleme bilgileri)
- ✅ Form validasyonları
- ✅ Hata yönetimi ve kullanıcı bildirimleri

#### 📊 Dışa Aktarma ve Yedekleme
- ✅ Excel'e aktarma (ClosedXML)
- ✅ Veritabanı yedekleme
- ✅ Veritabanı geri yükleme
- ✅ Otomatik tarih damgalı yedek dosyaları

### 🏗️ Mimari
- **Platform**: .NET 8 (LTS)
- **UI Framework**: Windows Forms
- **Database**: SQLite
- **ORM**: Entity Framework Core
- **Pattern**: Repository + Unit of Work
- **Architecture**: Clean Architecture (4 Layer)
  - Domain (Entities, Enums, Exceptions)
  - Data (DbContext, Repositories)
  - Business (Services, Validations)
  - UI (Forms, Helpers)

### 📦 Dağıtım
- **Tip**: Self-Contained Single-File Executable
- **Platform**: Windows x64
- **Boyut**: ~70-80 MB
- **Gereksinim**: Hiçbir ek yazılım gerekmez

### 🔒 Güvenlik
- ✅ Bağımlılık kontrolü (ilişkili kayıtlar silinemez)
- ✅ Input validasyonu
- ✅ Business rule validasyonu
- ✅ Exception handling

### 📝 Bilinen Sınırlamalar
- Tek kullanıcılı uygulama (Multi-user desteklenmez)
- Ağ üzerinden paylaşım yok
- Kullanıcı yönetimi yok (System kullanıcısı)
- Rol bazlı yetkilendirme yok

### 🎯 Gelecek Planlar (v0.1.0)
- 📊 Raporlama modülü
- 📈 Grafiksel gösterimler
- 🔍 Gelişmiş filtreleme ve arama
- 📅 Tarih aralığı filtreleri
- 🎨 Tema desteği (Dark/Light mode)
- 🔐 Kullanıcı yönetimi ve authentication
- 📱 Dashboard/Özet görünümü
- 🔔 Bildirim sistemi (düşük stok uyarıları)

### 🐛 Bilinen Hatalar
Şu an bilinen kritik hata bulunmamaktadır.

### 📚 Dokümantasyon
- ✅ Kurulum rehberi (INSTALLATION.md)
- ✅ Proje özeti (SUMMARY.md)
- ✅ Kullanım kılavuzu (README.md)

---

## 📥 İndirme
[Releases sayfasından](../../releases/tag/v0.0.1) indirin.

## 🙏 Teşekkürler
Bu projeyi kullandığınız için teşekkür ederiz! Geri bildirimlerinizi bekliyoruz.

