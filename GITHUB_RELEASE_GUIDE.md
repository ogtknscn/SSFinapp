# 🚀 GitHub Release Yayınlama Rehberi

## 📋 Hazırlık Tamamlandı! ✅

Aşağıdaki adımları takip ederek projeyi GitHub'da yayınlayabilirsiniz.

## 1️⃣ GitHub Repository Oluşturma

### GitHub Web Üzerinden:
1. [GitHub](https://github.com) üzerinde oturum açın
2. Sağ üstteki **"+"** butonuna tıklayın
3. **"New repository"** seçin
4. Repository bilgileri:
   - **Name**: `SSFinapp` veya `finans-uygulamasi`
   - **Description**: `On-premise çalışan finans ve stok yönetim uygulaması - Windows Desktop App`
   - **Visibility**: ✅ **Public** (Herkes görebilsin)
   - **Initialize**: ❌ Hiçbir şey SEÇMEYİN (README, .gitignore, license eklemeyin - zaten var!)
5. **"Create repository"** butonuna tıklayın

## 2️⃣ Repository'ye Push Etme

GitHub'da repository oluşturduktan sonra gösterilen komutları kullanın:

```powershell
# Remote ekle (REPO_URL'i kendi repository URL'niz ile değiştirin)
git remote add origin https://github.com/KULLANICI_ADI/REPO_ADI.git

# Main branch olarak ayarla
git branch -M main

# Push et (kod + tag)
git push -u origin main
git push origin v0.0.1
```

### Örnek:
```powershell
git remote add origin https://github.com/ssteam/SSFinapp.git
git branch -M main
git push -u origin main
git push origin v0.0.1
```

## 3️⃣ GitHub Release Oluşturma

### Web Üzerinden Release Oluşturma:

1. GitHub repository sayfanıza gidin
2. Sağ tarafta **"Releases"** bölümünü bulun
3. **"Create a new release"** veya **"Draft a new release"** butonuna tıklayın

### Release Bilgileri:

**Choose a tag:**
- `v0.0.1` seçin (zaten push ettiniz)

**Release title:**
```
v0.0.1 - İlk Yayın (Initial Release)
```

**Description:** (Aşağıdaki içeriği kopyalayın)

```markdown
## 🎉 İlk Sürüm - S&S Finans Uygulaması

On-premise çalışan, kullanıcı dostu bir finans ve stok yönetim uygulaması.

### ✨ Özellikler

#### 📦 Stok Yönetimi
- ✅ Ürün ekleme, düzenleme, silme
- ✅ Stok giriş/çıkış işlemleri
- ✅ Anlık stok seviyesi görüntüleme
- ✅ Negatif stok kontrolü

#### 👥 Müşteri & Cari Hesap
- ✅ Müşteri yönetimi (CRUD)
- ✅ İletişim bilgileri yönetimi
- ✅ Otomatik telefon formatlaması
- ✅ Para ve mal bazlı cari işlemler
- ✅ Bakiye hesaplama

#### 📊 Raporlama
- ✅ Excel'e aktarma
- ✅ Veritabanı yedekleme ve geri yükleme

#### 🔒 Güvenlik
- ✅ Input validasyonu
- ✅ Business rule kontrolü
- ✅ Bağımlılık kontrolü

### 📥 İndirme ve Kurulum

1. **SSFinapp-v0.0.1-win-x64.zip** dosyasını indirin
2. ZIP'i istediğiniz klasöre ayıklayın
3. **SSFinapp.UI.exe** dosyasını çalıştırın
4. Hiçbir ek yazılım gerekmez! 🎉

### 💻 Sistem Gereksinimleri
- Windows 10/11 (64-bit)
- 2 GB RAM
- 150 MB disk alanı

### 📚 Dokümantasyon
- Detaylı kurulum rehberi için [INSTALLATION.md](INSTALLATION.md) dosyasına bakın
- Tüm özellikler için [README.md](README.md) dosyasına bakın

### 🐛 Sorun Bildirimi
Bir hata veya sorunla karşılaşırsanız [Issues](../../issues) sayfasında bildirebilirsiniz.

### 🙏 Teşekkürler
Bu projeyi kullandığınız için teşekkür ederiz!

---

**Made with ❤️ by S&S Team**
```

**Attach binaries:**
- **"Attach binaries by dropping them here or selecting them"** bölümüne tıklayın
- **`SSFinapp-v0.0.1-win-x64.zip`** dosyasını seçin veya sürükleyip bırakın

**Options:**
- ✅ **"Set as the latest release"** işaretli olsun

### 4️⃣ Yayınla!

**"Publish release"** butonuna tıklayın! 🎉

## 4️⃣ Doğrulama

Release yayınlandıktan sonra:

1. ✅ Repository ana sayfasında "Latest" badge görünmeli
2. ✅ Releases sayfasında v0.0.1 görünmeli
3. ✅ ZIP dosyası indirilebilir olmalı
4. ✅ README.md düzgün görüntülenmeli

## 📊 Release Dosyaları

Repository'nizde şu dosyalar bulunuyor:

```
✅ README.md                          - Ana sayfa (badges ile)
✅ INSTALLATION.md                    - Kurulum rehberi
✅ RELEASE_NOTES.md                   - Sürüm notları
✅ LICENSE                            - MIT lisansı
✅ SUMMARY.md                         - Proje özeti
✅ PROJECT_PLAN.md                    - Planlama dökümanı
✅ SSFinapp-v0.0.1-win-x64.zip       - Release paketi
✅ .gitignore                         - Git ignore kuralları
```

## 🎯 Sonraki Adımlar

### Repository Ayarları (Opsiyonel):
1. **About** bölümünü düzenleyin:
   - Description: "On-premise finans ve stok yönetim uygulaması"
   - Website: Release URL'inizi ekleyin
   - Topics: `windows`, `desktop-app`, `finance`, `stock-management`, `dotnet`, `winforms`, `sqlite`

2. **README badges** otomatik çalışacak (version, platform, .NET, license)

3. **Issues** tab'ini aktifleştirin (varsayılan açık)

4. **Discussions** tab'ini aktifleştirin (opsiyonel)

## 🔗 Paylaşım

Release yayınlandıktan sonra paylaşabileceğiniz linkler:

- **Repository**: `https://github.com/KULLANICI_ADI/REPO_ADI`
- **Release**: `https://github.com/KULLANICI_ADI/REPO_ADI/releases/tag/v0.0.1`
- **Direct Download**: `https://github.com/KULLANICI_ADI/REPO_ADI/releases/download/v0.0.1/SSFinapp-v0.0.1-win-x64.zip`

## ✨ Tebrikler!

Projeniz artık GitHub'da public olarak yayında! 🎉

Kullanıcılar:
- ✅ Kodu inceleyebilir
- ✅ Uygulamayı indirebilir
- ✅ Issue açabilir
- ✅ Fork ve PR gönderebilir
- ✅ Star verebilir ⭐

---

**İyi yayınlar! 🚀**

