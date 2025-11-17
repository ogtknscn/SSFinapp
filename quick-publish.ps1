# S&S Finans Uygulamasi - GitHub Yayinlama Scripti
# Bu scripti calistirmadan once GitHub CLI (gh) yuklu olmali
# Kurulum: winget install GitHub.cli

Write-Host "================================================================" -ForegroundColor Cyan
Write-Host "     S&S FINANS UYGULAMASI - GITHUB YAYINLAMA SCRIPTI          " -ForegroundColor Cyan
Write-Host "================================================================" -ForegroundColor Cyan
Write-Host ""

# GitHub CLI kontrolu
Write-Host "[1/6] GitHub CLI kontrol ediliyor..." -ForegroundColor Yellow
$ghInstalled = Get-Command gh -ErrorAction SilentlyContinue

if (-not $ghInstalled) {
    Write-Host "HATA: GitHub CLI bulunamadi!" -ForegroundColor Red
    Write-Host ""
    Write-Host "Lutfen GitHub CLI'yi yukleyin:" -ForegroundColor Yellow
    Write-Host "  winget install GitHub.cli" -ForegroundColor White
    Write-Host "veya" -ForegroundColor Yellow
    Write-Host "  https://cli.github.com/" -ForegroundColor White
    Write-Host ""
    Write-Host "Kurulumdan sonra bu scripti tekrar calistirin." -ForegroundColor Yellow
    exit 1
}

Write-Host "OK: GitHub CLI mevcut!" -ForegroundColor Green
Write-Host ""

# GitHub authentication kontrolu
Write-Host "[2/6] GitHub oturum kontrol ediliyor..." -ForegroundColor Yellow
$authStatus = gh auth status 2>&1

if ($authStatus -like "*not logged*" -or $authStatus -like "*not authenticated*") {
    Write-Host "UYARI: GitHub'a giris yapilmamis!" -ForegroundColor Yellow
    Write-Host "GitHub'a giris yapiliyor..." -ForegroundColor Yellow
    gh auth login
    if ($LASTEXITCODE -ne 0) {
        Write-Host "HATA: GitHub girisi basarisiz!" -ForegroundColor Red
        exit 1
    }
}

Write-Host "OK: GitHub oturumu aktif!" -ForegroundColor Green
Write-Host ""

# Repository adi sor
Write-Host "[3/6] Repository bilgileri aliniyor..." -ForegroundColor Yellow
$repoName = Read-Host "Repository adi (Enter = SSFinapp)"
if ([string]::IsNullOrWhiteSpace($repoName)) {
    $repoName = "SSFinapp"
}

$repoDesc = "On-premise finans ve stok yonetim uygulamasi - Windows Desktop App"

Write-Host ""
Write-Host "Repository Bilgileri:" -ForegroundColor Cyan
Write-Host "  Adi: $repoName" -ForegroundColor White
Write-Host "  Aciklama: $repoDesc" -ForegroundColor White
Write-Host "  Gorunurluk: Public" -ForegroundColor White
Write-Host ""

$confirm = Read-Host "Devam edilsin mi? (E/H)"
if ($confirm -ne "E" -and $confirm -ne "e") {
    Write-Host "Iptal edildi." -ForegroundColor Yellow
    exit 0
}

# Repository olustur
Write-Host ""
Write-Host "[4/6] GitHub repository olusturuluyor..." -ForegroundColor Yellow
gh repo create $repoName --public --description $repoDesc --source=. --remote=origin

if ($LASTEXITCODE -ne 0) {
    Write-Host "HATA: Repository olusturulamadi!" -ForegroundColor Red
    Write-Host "Repository zaten var olabilir. Manuel olarak olusturmaniz gerekebilir." -ForegroundColor Yellow
    exit 1
}

Write-Host "OK: Repository olusturuldu!" -ForegroundColor Green
Write-Host ""

# Push
Write-Host "[5/6] Kod GitHub'a gonderiliyor..." -ForegroundColor Yellow
git branch -M main
git push -u origin main

if ($LASTEXITCODE -ne 0) {
    Write-Host "HATA: Push basarisiz!" -ForegroundColor Red
    exit 1
}

Write-Host "OK: Kod gonderildi!" -ForegroundColor Green
Write-Host ""

# Tag push
Write-Host "[5.5/6] Tag gonderiliyor..." -ForegroundColor Yellow
git push origin v0.0.1

if ($LASTEXITCODE -ne 0) {
    Write-Host "HATA: Tag push basarisiz!" -ForegroundColor Red
    exit 1
}

Write-Host "OK: Tag gonderildi!" -ForegroundColor Green
Write-Host ""

# Release olustur
Write-Host "[6/6] GitHub Release olusturuluyor..." -ForegroundColor Yellow

$releaseNotes = @"
## First Release - S&S Finance Application

On-premise finance and stock management application.

### Features

**Stock Management**
- Product management (CRUD)
- Stock transactions (In/Out)
- Real-time stock levels
- Negative stock prevention

**Customer & Current Account**
- Customer management (CRUD)
- Contact information management
- Auto phone formatting
- Cash and goods transactions
- Balance calculation

**Reporting**
- Excel export
- Database backup and restore

**Security**
- Input validation
- Business rule enforcement
- Cascade delete protection

### Installation

1. Download **SSFinapp-v0.0.1-win-x64.zip**
2. Extract to desired location
3. Run **SSFinapp.UI.exe**
4. No additional software required!

### System Requirements
- Windows 10/11 (64-bit)
- 2 GB RAM
- 150 MB disk space

### Documentation
- [Installation Guide](INSTALLATION.md)
- [Quick Start](QUICK_START.md)
- [README](README.md)

---

**Made with love by S&S Team**
"@

gh release create v0.0.1 `
    --title "v0.0.1 - Initial Release" `
    --notes $releaseNotes `
    --latest `
    "SSFinapp-v0.0.1-win-x64.zip"

if ($LASTEXITCODE -ne 0) {
    Write-Host "HATA: Release olusturulamadi!" -ForegroundColor Red
    Write-Host "Manuel olarak olusturmaniz gerekebilir." -ForegroundColor Yellow
    exit 1
}

Write-Host "OK: Release olusturuldu!" -ForegroundColor Green
Write-Host ""

# Basari mesaji
Write-Host "================================================================" -ForegroundColor Green
Write-Host "                  BASARIYLA YAYINLANDI!                        " -ForegroundColor Green
Write-Host "================================================================" -ForegroundColor Green
Write-Host ""

# Repository URL'ini al
$repoUrl = gh repo view --json url --jq .url

Write-Host "Repository URL:" -ForegroundColor Cyan
Write-Host "   $repoUrl" -ForegroundColor White
Write-Host ""
Write-Host "Release URL:" -ForegroundColor Cyan
Write-Host "   $repoUrl/releases/tag/v0.0.1" -ForegroundColor White
Write-Host ""
Write-Host "Tarayicida acmak ister misiniz? (E/H)" -ForegroundColor Yellow
$openBrowser = Read-Host

if ($openBrowser -eq "E" -or $openBrowser -eq "e") {
    Start-Process $repoUrl
}

Write-Host ""
Write-Host "Projeniz artik GitHub'da yayinda!" -ForegroundColor Green
Write-Host ""
