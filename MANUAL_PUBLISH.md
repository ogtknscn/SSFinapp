# 📋 Manuel GitHub Yayınlama Rehberi

GitHub CLI yüklü değilse, bu adımları manuel olarak takip edin.

## 🎯 Adım Adım Talimatlar

### ADIM 1: GitHub'da Repository Oluştur (Web Üzerinden)

1. **Tarayıcınızda** [https://github.com/new](https://github.com/new) adresine gidin

2. **Repository Bilgileri:**
   ```
   Repository name:        SSFinapp
   Description:            On-premise finans ve stok yönetim uygulaması
   Visibility:             ✅ Public
   
   ❌ Add a README file       (KAPATIK - zaten var!)
   ❌ Add .gitignore          (KAPATIK - zaten var!)
   ❌ Choose a license        (KAPATIK - zaten var!)
   ```

3. **"Create repository"** butonuna tıklayın

4. Açılan sayfada gösterilen komutları **KOPYALAMAYIN**, aşağıdaki komutları kullanın!

---

### ADIM 2: Repository URL'ini Alın

GitHub'da repository oluşturduktan sonra, sayfanın üstünde görünen URL'i kopyalayın:

```
https://github.com/KULLANICI_ADI/SSFinapp
```

Veya "Code" butonuna tıklayıp HTTPS URL'i kopyalayın:

```
https://github.com/KULLANICI_ADI/SSFinapp.git
```

---

### ADIM 3: PowerShell'de Bu Komutları Çalıştırın

Aşağıdaki komutları **SIRAYLA** çalıştırın. 

**⚠️ ÖNEMLI:** `KULLANICI_ADI` kısmını kendi GitHub kullanıcı adınızla değiştirin!

```powershell
# 1. Remote ekle (KULLANICI_ADI'ni değiştirin!)
git remote add origin https://github.com/KULLANICI_ADI/SSFinapp.git

# 2. Branch adını main yap
git branch -M main

# 3. Kodu GitHub'a gönder
git push -u origin main

# 4. Tag'i GitHub'a gönder
git push origin v0.0.1
```

**Örnek (kullanıcı adı: johndoe):**
```powershell
git remote add origin https://github.com/johndoe/SSFinapp.git
git branch -M main
git push -u origin main
git push origin v0.0.1
```

---

### ADIM 4: GitHub Release Oluşturun

1. **Repository sayfasında** sağ tarafta **"Releases"** linkine tıklayın

2. **"Create a new release"** veya **"Draft a new release"** butonuna tıklayın

3. **Release Bilgileri:**

   **Choose a tag:**
   ```
   v0.0.1  (dropdown'dan seçin)
   ```

   **Release title:**
   ```
   v0.0.1 - İlk Yayın (Initial Release)
   ```

   **Description:** (Aşağıdaki metni kopyalayın)
   ```markdown
   ## 🎉 İlk Sürüm - S&S Finans Uygulaması

   On-premise finans ve stok yönetim uygulaması.

   ### ✨ Özellikler

   **📦 Stok Yönetimi**
   - ✅ Ürün yönetimi (CRUD)
   - ✅ Stok giriş/çıkış işlemleri
   - ✅ Anlık stok seviyeleri
   - ✅ Negatif stok kontrolü

   **👥 Müşteri & Cari Hesap**
   - ✅ Müşteri yönetimi (CRUD)
   - ✅ İletişim bilgileri yönetimi
   - ✅ Otomatik telefon formatlaması
   - ✅ Para ve mal bazlı işlemler
   - ✅ Bakiye hesaplama

   **📊 Raporlama**
   - ✅ Excel'e aktarma
   - ✅ Veritabanı yedekleme ve geri yükleme

   **🔒 Güvenlik**
   - ✅ Input validasyonu
   - ✅ Business rule kontrolü
   - ✅ Cascade delete protection

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
   - [Kurulum Rehberi](INSTALLATION.md)
   - [Hızlı Başlangıç](QUICK_START.md)
   - [README](README.md)

   ### 🐛 Sorun Bildirimi
   [Issues](../../issues) sayfasında bildirebilirsiniz.

   ---

   **Made with ❤️ by S&S Team**
   ```

4. **Attach binaries:**
   - "Attach binaries by dropping them here or selecting them" alanına tıklayın
   - `SSFinapp-v0.0.1-win-x64.zip` dosyasını seçin veya sürükleyin
   - Yüklenmesini bekleyin

5. **Options:**
   - ✅ **"Set as the latest release"** işaretli olsun

6. **"Publish release"** butonuna tıklayın! 🚀

---

## ✅ Kontrol Listesi

Release yayınlandıktan sonra:

- [ ] Repository ana sayfası açılıyor mu?
- [ ] README düzgün görünüyor mu?
- [ ] Releases sayfası var mı?
- [ ] v0.0.1 release görünüyor mu?
- [ ] ZIP dosyası indirilebiliyor mu?
- [ ] License görünüyor mu?

---

## 🎯 Tamamlandı!

Projeniz artık GitHub'da public olarak yayında! 🎉

**Repository URL'niz:**
```
https://github.com/KULLANICI_ADI/SSFinapp
```

**Release URL'niz:**
```
https://github.com/KULLANICI_ADI/SSFinapp/releases/tag/v0.0.1
```

**Download Link:**
```
https://github.com/KULLANICI_ADI/SSFinapp/releases/download/v0.0.1/SSFinapp-v0.0.1-win-x64.zip
```

---

## 💡 Sonraki Adımlar

### About Bölümünü Düzenle:
1. Repository ana sayfa → **"About"** ⚙️
2. **Topics** ekle: `windows`, `desktop-app`, `finance`, `stock-management`, `dotnet`, `winforms`, `sqlite`

### Sosyal Medyada Paylaş:
```
🚀 S&S Finans Uygulaması v0.0.1 yayında!

✅ Stok yönetimi
✅ Cari hesap takibi  
✅ Excel export
✅ Tamamen offline
✅ Açık kaynak (MIT)

İndir: [REPO_URL]/releases/tag/v0.0.1

#dotnet #winforms #opensource
```

---

**Tebrikler! Projeniz dünya ile paylaşıldı! 🌍**

