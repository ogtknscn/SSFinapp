# 📦 S&S Finans Uygulaması - Kurulum Rehberi

## 🎯 Genel Bakış
S&S Finans Uygulaması, stok ve cari hesap yönetimi için geliştirilmiş masaüstü bir uygulamadır. Tamamen yerel (on-premise) çalışır ve internet bağlantısı gerektirmez.

## 💻 Sistem Gereksinimleri
- **İşletim Sistemi**: Windows 10/11 (64-bit)
- **Bellek**: Minimum 2 GB RAM
- **Disk Alanı**: 150 MB boş alan
- **Ek Yazılım**: **Hiçbir şey gerekmez!** (Uygulama .NET Runtime'ı içerir)

## 📥 Kurulum Adımları

### 1. İndirme
1. [GitHub Releases](../../releases) sayfasına gidin
2. En son sürümü bulun (örn: v0.0.1)
3. **`SSFinapp-v0.0.1-win-x64.zip`** dosyasını indirin

### 2. Kurulum
1. İndirilen ZIP dosyasını **sağ tıklayın** → **Tümünü Ayıkla**
2. İstediğiniz bir klasöre ayıklayın (örn: `C:\Program Files\SSFinapp`)
3. Klasör içinde **`SSFinapp.UI.exe`** dosyasını bulun
4. **Çift tıklayarak** çalıştırın! 🎉

### 3. İlk Çalıştırma
- İlk açılışta veritabanı otomatik olarak oluşturulacaktır
- `ssfinapp.db` dosyası exe ile aynı klasörde görünecektir
- Uygulama kullanıma hazırdır!

## 🔧 Kullanım

### Ana Özellikler
- ✅ **Ürün Yönetimi**: Ürün ekleme, düzenleme, silme
- 📊 **Stok Takibi**: Giriş/Çıkış işlemleri, anlık stok görüntüleme
- 👥 **Müşteri Yönetimi**: Müşteri bilgileri yönetimi
- 💰 **Cari Hesap**: Para ve mal bazlı cari hesap takibi
- 📑 **Excel Export**: Verileri Excel'e aktarma
- 💾 **Yedekleme**: Veritabanı yedekleme ve geri yükleme

### Hızlı Başlangıç
1. Ana menüden **"Ürün Yönetimi"** ile başlayın
2. İlk ürününüzü ekleyin
3. **"Stok İşlemleri"** ile stok giriş/çıkış yapın
4. **"Müşteri Yönetimi"** ile müşteri ekleyin
5. **"Cari İşlemler"** ile müşteri işlemlerini takip edin

## 🔒 Veri Güvenliği

### Yedekleme
- **Menü**: Ana Form → Yedek Al
- Yedekler varsayılan olarak `Backups\` klasörüne kaydedilir
- **Öneri**: Düzenli yedek almayı unutmayın!

### Geri Yükleme
- **Menü**: Ana Form → Yedek Geri Yükle
- Önceden alınmış bir yedeği seçin
- Dikkat: Mevcut veriler yedeğin üzerine yazılacaktır!

## 📤 Excel'e Aktarma
- Her liste formunda **"Excel'e Aktar"** butonu bulunur
- Verilerinizi Excel formatında dışa aktarabilirsiniz
- Dosya konumunu kendiniz seçebilirsiniz

## 🗂️ Klasör Yapısı
```
SSFinapp/
├── SSFinapp.UI.exe          # Ana program dosyası
├── ssfinapp.db              # Veritabanı (otomatik oluşur)
├── Backups/                 # Yedekler (otomatik oluşur)
│   └── backup_YYYYMMDD_HHMMSS.db
└── *.pdb                    # Debug dosyaları (opsiyonel)
```

## ❓ Sık Sorulan Sorular

### Q: Uygulama açılmıyor, ne yapmalıyım?
**A:** 
- Windows SmartScreen uyarısı çıkarsa: "Daha fazla bilgi" → "Yine de çalıştır"
- Antivirüs yazılımınız tarafından engelleniyorsa: Uygulamayı güvenli listesine ekleyin

### Q: Veritabanı dosyasını kaybedersem ne olur?
**A:** Tüm veriler kaybolur. Bu nedenle düzenli yedek almak çok önemlidir!

### Q: Uygulamayı başka bir bilgisayara nasıl taşırım?
**A:** 
1. `ssfinapp.db` dosyasını yedekleyin
2. Yeni bilgisayarda uygulamayı kurun
3. `ssfinapp.db` dosyasını yeni kurulumun klasörüne kopyalayın

### Q: İnternet bağlantısı gerekli mi?
**A:** Hayır! Uygulama tamamen çevrimdışı (offline) çalışır.

### Q: Birden fazla kullanıcı aynı anda kullanabilir mi?
**A:** Hayır. Uygulama tek kullanıcılı ve yerel bir uygulamadır. Ağ üzerinden paylaşım desteklenmez.

### Q: Silinmiş kayıtları geri getirebilir miyim?
**A:** Hayır. Silme işlemleri kalıcıdır. Ancak önceden yedek aldıysanız, o yedeği geri yükleyebilirsiniz.

## 🐛 Sorun Bildirimi
Bir hata veya sorunla karşılaşırsanız:
1. [GitHub Issues](../../issues) sayfasını ziyaret edin
2. Yeni bir issue açın
3. Sorununuzu detaylı açıklayın

## 📝 Lisans
Bu proje açık kaynaklıdır ve MIT lisansı altında dağıtılmaktadır.

## 🔄 Güncelleme
Yeni sürümler için [GitHub Releases](../../releases) sayfasını takip edin.

---

**İyi kullanımlar! 🎉**

