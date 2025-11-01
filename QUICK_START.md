# ⚡ Hızlı Başlangıç Rehberi

## 📦 İndirme ve Kurulum (5 Dakika)

### Adım 1: İndir
1. [GitHub Releases](../../releases/latest) sayfasına git
2. **SSFinapp-v0.0.1-win-x64.zip** dosyasını indir (~68 MB)

### Adım 2: Çıkar
1. ZIP dosyasını sağ tıkla → **Tümünü Ayıkla**
2. İstediğin klasöre çıkar (örn: `C:\SSFinapp`)

### Adım 3: Çalıştır
1. Klasörde **SSFinapp.UI.exe** dosyasını bul
2. Çift tıkla ve çalıştır! 🎉

> ⚠️ **Windows SmartScreen uyarısı çıkarsa:**
> - "Daha fazla bilgi" → "Yine de çalıştır" seçin

## 🎯 İlk Kullanım (10 Dakika)

### 1. Ürün Ekle
1. Ana menüden **"Ürün Yönetimi"** butonuna tıkla
2. **"Yeni Ürün"** butonuna tıkla
3. Bilgileri doldur:
   - **Ürün Adı**: Örn: "Çimento"
   - **Birim**: Örn: "Torba"
   - **Aktif**: ✅ İşaretle
4. **"Kaydet"** butonuna tıkla

### 2. Stok Giriş Yap
1. Ana menüden **"Stok İşlemleri"** butonuna tıkla
2. **"Yeni İşlem"** butonuna tıkla
3. Bilgileri doldur:
   - **İşlem Tipi**: "Giriş"
   - **Ürün**: Daha önce eklediğin ürünü seç
   - **Miktar**: Örn: "100"
   - **Tarih**: Bugünün tarihi
4. **"Kaydet"** butonuna tıkla
5. Anlık stok seviyesini görebilirsin!

### 3. Müşteri Ekle
1. Ana menüden **"Müşteri Yönetimi"** butonuna tıkla
2. **"Yeni Müşteri"** butonuna tıkla
3. Bilgileri doldur:
   - **Ad**: Örn: "Ahmet Yılmaz"
   - **Telefon**: Örn: "05321234567"
   - **Email**: Örn: "ahmet@example.com"
   - **Adres**: Örn: "İstanbul"
4. **"Kaydet"** butonuna tıkla

### 4. Cari İşlem Ekle
1. Ana menüden **"Cari İşlemler"** butonuna tıkla
2. Üst taraftan müşteri seç
3. **"Yeni İşlem"** butonuna tıkla
4. Bilgileri doldur:
   - **Tarih**: Bugünün tarihi
   - **Malzeme**: Örn: "Çimento satışı"
   - **Tutar**: Örn: "5000"
   - **Verilen**: Örn: "5000" (Müşteriye verdik)
   - **İşlem Tipi**: "Para"
5. **"Kaydet"** butonuna tıkla
6. Müşteri bakiyesini görebilirsin!

## 📊 Excel'e Aktarma

Her liste ekranında:
1. **"Excel'e Aktar"** butonuna tıkla
2. Kaydetmek istediğin yeri seç
3. Dosya otomatik açılır! 📑

## 💾 Yedekleme

Ana menüden:
1. **"Yedek Al"** butonuna tıkla (Menü Bar'da)
2. Kaydetmek istediğin yeri seç
3. Yedek oluşturuldu! ✅

### Yedek Geri Yükleme:
1. **"Yedek Geri Yükle"** butonuna tıkla
2. Yedek dosyasını seç
3. Onaylayın → Veriler geri yüklendi! ✅

## 🎓 İpuçları

### ✨ En İyi Pratikler:
1. **Düzenli Yedek Al**: Haftada en az bir kez yedek almayı unutma!
2. **Telefon Formatı**: Otomatik formatlanır (05XX XXX XX XX)
3. **Stok Kontrolü**: Negatif stok yapılamaz, sistem uyarır
4. **Silme İşlemi**: Bağımlı kayıtlar silinemez (güvenlik)
5. **Excel Export**: Tüm verileri Excel'de analiz edebilirsin

### 🚫 Yapmaman Gerekenler:
- ❌ Veritabanı dosyasını (`ssfinapp.db`) manuel olarak silme
- ❌ Uygulama açıkken veritabanını kopyalama
- ❌ Birden fazla örnek açma (aynı klasörden)

### 🔧 Dosya Konumları:
```
SSFinapp/
├── SSFinapp.UI.exe          # Program
├── ssfinapp.db              # Veritabanı (Otomatik oluşur)
├── Backups/                 # Yedekler (Otomatik oluşur)
├── INSTALLATION.md          # Kurulum rehberi
└── LICENSE                  # Lisans
```

## 🐛 Sorun mu Yaşıyorsun?

### Sık Karşılaşılan Sorunlar:

**Q: Uygulama açılmıyor**
- Antivirüs yazılımını kontrol et
- Windows Defender güvenli listesine ekle

**Q: Veritabanı hatası alıyorum**
- Veritabanı dosyası bozulmuş olabilir
- Yedeğinizi geri yükleyin

**Q: Excel export çalışmıyor**
- Excel yüklü olması gerekmez
- Dosya konumu yazılabilir olmalı

**Q: Telefon formatı kabul edilmiyor**
- Format: 05XX XXX XX XX
- Örnek: 0532 123 45 67

### Yardım İçin:
- 📖 [Detaylı Kurulum Rehberi](INSTALLATION.md)
- 📚 [README](README.md)
- 🐛 [GitHub Issues](../../issues)

## 📈 Sonraki Adımlar

Temel kullanımı öğrendin! Şimdi:
1. ✅ Kendi ürünlerini ekle
2. ✅ Stok hareketlerini kaydet
3. ✅ Müşterilerini yönet
4. ✅ Cari hesapları takip et
5. ✅ Excel raporları oluştur
6. ✅ Düzenli yedek al

## 💡 Özellik İstekleri

Yeni özellik isteklerin için [GitHub Issues](../../issues) sayfasında öneride bulunabilirsin!

---

**İyi kullanımlar! 🎉**

*Hazırlayanlar: S&S Finans Ekibi*

