# 🏪 StoreFlow - Mağaza Yönetim Sistemi

**Versiyon:** Alpha 1.0.0  
**Platform:** Windows Desktop (.NET 8.0)  
**Geliştirici:** [@toprak-coder](https://github.com/toprak-coder)

---

## 📋 İçindekiler
- [Proje Hakkında](#-proje-hakkında)
- [Özellikler](#-özellikler)
- [Teknolojiler](#-teknolojiler)
- [Kurulum](#-kurulum)
- [Veritabanı Yapılandırması](#-veritabanı-yapılandırması)
- [Kullanım](#-kullanım)
- [Ekran Görüntüleri](#-ekran-görüntüleri)
- [Proje Yapısı](#-proje-yapısı)
- [Katkıda Bulunma](#-katkıda-bulunma)
- [Lisans](#-lisans)

---

## 🎯 Proje Hakkında

**StoreFlow**, küçük ve orta ölçekli işletmeler için geliştirilmiş modern bir mağaza ve ürün yönetim sistemidir. Windows Forms teknolojisi kullanılarak C# ile geliştirilmiş bu uygulama, kullanıcı dostu arayüzü ve kapsamlı özellikleriyle ürün envanteri yönetimini kolaylaştırır.

### 🎨 Uygulama Adı: **StoreFlow**
- **Store** (Mağaza): Ticari işletmeleri temsil eder
- **Flow** (Akış): Süreçlerin akıcı ve kolay yönetimini simgeler

---

## ✨ Özellikler

### 🔐 Kullanıcı Yönetimi
- **Kayıt Sistemi**: Yeni kullanıcı kaydı oluşturma
  - Kullanıcı adı, şifre, tam ad
  - Cinsiyet seçimi
  - Doğum tarihi kaydı
- **Giriş Sistemi**: Güvenli kullanıcı girişi
  - Kullanıcı doğrulama
  - Şifre kontrolü
  - Hata yönetimi
- **Profil Yönetimi**: Kullanıcı bilgilerini güncelleme ve hesap silme

### 📦 Ürün Yönetimi
- **Ürün Ekleme**: Yeni ürünler ekleme
  - Ürün adı
  - Ürün açıklaması/detayları
  - Kategori seçimi
- **Ürün Düzenleme**: Mevcut ürünleri güncelleme
  - ID veya isim ile ürün arama
  - Tüm ürün bilgilerini düzenleme
  - Güncelleme tarihi takibi
- **Ürün Silme**: Ürünleri sistemden kaldırma
  - Tekli silme (ID veya isim ile)
  - Çoklu silme (ID aralığı: 12-16)
  - Toplu silme (Virgülle ayrılmış: 12,13,14)
- **Ürün Görüntüleme**: Tüm ürünleri listeleme
  - Modern DataGridView tasarımı
  - Filtreleme ve sıralama
  - Detaylı ürün bilgileri

### 🏷️ Kategori Yönetimi
- **Kategori Ekleme**: Yeni ürün kategorileri oluşturma
- **Kategori Silme**: Mevcut kategorileri kaldırma
- **Kategori Listeleme**: Tüm kategorileri görüntüleme

### 📊 Dashboard (Kontrol Paneli)
- Hoş geldin mesajı
- Anlık saat gösterimi
- Hızlı erişim butonları:
  - Ürün Ekle
  - Ürün Sil
  - Ürün Düzenle
  - Ürün Detayları
  - Kategori Yönetimi
  - Ayarlar
- Sosyal medya bağlantıları (GitHub, Twitter/X)

### ⚙️ Ayarlar
- Kullanıcı adı değiştirme
- Şifre değiştirme
- Hesap silme
- Güvenli güncelleme sistemi

---

## 🛠️ Teknolojiler

### Temel Teknolojiler
- **Framework**: .NET 8.0 (Windows Forms)
- **Dil**: C# 
- **IDE**: Visual Studio 2022
- **Veritabanı**: Microsoft SQL Server (SQL Express)

### NuGet Paketleri
```xml
- Microsoft.Data.SqlClient (6.1.1) - Veritabanı bağlantısı
- ReaLTaiizor (3.8.1.3) - Modern UI bileşenleri
- Syncfusion.Chart.Windows (31.1.21) - Grafik ve chart desteği
- Syncfusion.Shared.Base (31.1.21) - Syncfusion temel bileşenler
- System.Data.SqlClient (4.9.0) - SQL veri erişimi
- WinForms.DataVisualization (1.10.0) - Veri görselleştirme
```

---

## 📥 Kurulum

### Gereksinimler
1. **Windows 10/11** (64-bit)
2. **.NET 8.0 Runtime** veya SDK
3. **SQL Server** (Express Edition yeterli)
4. **Visual Studio 2022** (Geliştirme için)

### Adım Adım Kurulum

#### 1. Projeyi İndirin
```bash
git clone https://github.com/toprak-coder/magaza-uygulamas-winform.git
cd magaza-uygulamas-winform
```

#### 2. .NET 8.0 SDK Kurulumu
[.NET 8.0 SDK İndir](https://dotnet.microsoft.com/download/dotnet/8.0)

#### 3. SQL Server Kurulumu
- [SQL Server Express İndir](https://www.microsoft.com/sql-server/sql-server-downloads)
- SQL Server Management Studio (SSMS) önerilir

#### 4. Projeyi Açın
```bash
# Visual Studio ile açın
start "login and register.sln"

# Veya komut satırından derleyin
dotnet restore
dotnet build
```

---

## 🗄️ Veritabanı Yapılandırması

### 1. Veritabanı Oluşturma
SQL Server Management Studio'da aşağıdaki SQL komutlarını çalıştırın:

```sql
-- Veritabanı oluştur
CREATE DATABASE ImLazy;
GO

USE ImLazy;
GO

-- Users tablosu
CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(50) NOT NULL UNIQUE,
    passcode NVARCHAR(100) NOT NULL,
    _name NVARCHAR(100) NOT NULL,
    gender NVARCHAR(10),
    dob DATE,
    CreatedDate DATETIME DEFAULT GETDATE()
);

-- Products tablosu
CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    ProductData NVARCHAR(MAX),
    Category NVARCHAR(50),
    CreatedDate DATETIME DEFAULT GETDATE(),
    UpdatedDate DATETIME DEFAULT GETDATE()
);

-- İndeksler
CREATE INDEX IX_Users_Username ON Users(username);
CREATE INDEX IX_Products_Category ON Products(Category);
CREATE INDEX IX_Products_Name ON Products(Name);
```

### 2. Connection String Güncelleme

Tüm `.cs` dosyalarındaki connection string'i kendi SQL Server bilgilerinize göre güncelleyin:

**Mevcut:**
```csharp
@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"
```

**Güncelleme:**
```csharp
@"Data Source=SIZIN_SUNUCU_ADINIZ\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"
```

**Güncellenecek Dosyalar:**
- `LoginForm.cs`
- `RegisterForm.cs`
- `UrunEkle.cs`
- `UrunSil.cs`
- `UrunDuzenleWinform.cs`
- `UrunleriGoruntule.cs`
- `KategoriEkle.cs`
- `Ayarlar.cs`

### 3. SQL Server Adınızı Bulma
```sql
-- SQL Server Management Studio'da çalıştırın
SELECT @@SERVERNAME AS ServerName;
```

---

## 🚀 Kullanım

### İlk Çalıştırma

1. **Uygulamayı Başlatın**
   ```bash
   dotnet run --project "login and register/login and register.csproj"
   ```

2. **Kayıt Olun**
   - "Register" butonuna tıklayın
   - Kullanıcı bilgilerinizi girin
   - Hesabınızı oluşturun

3. **Giriş Yapın**
   - Kullanıcı adı ve şifrenizi girin
   - "Login" butonuna tıklayın

### Ana Özellikler

#### 📦 Ürün Ekleme
1. Sol menüden "Ürün Ekle" seçin
2. Ürün adını girin
3. Ürün açıklamasını yazın
4. Kategori seçin
5. "Ekle" butonuna tıklayın

#### ✏️ Ürün Düzenleme
1. Sol menüden "Ürün Düzenle" seçin
2. Düzenlemek istediğiniz ürünü seçin
3. Bilgileri güncelleyin
4. "Güncelle" butonuna tıklayın

#### 🗑️ Ürün Silme
1. Sol menüden "Ürün Sil" seçin
2. Silme yöntemi seçin:
   - **Tekli**: Ürün ID'si (örn: `5`)
   - **Aralık**: ID aralığı (örn: `5-10`)
   - **Çoklu**: Virgülle ayrılmış (örn: `5,7,9`)
   - **İsim**: Ürün adı
3. "Sil" butonuna tıklayın

#### 📊 Ürün Görüntüleme
1. Sol menüden "Ürün Detayları" seçin
2. Tüm ürünleri tabloda görün
3. Sıralama ve filtreleme yapın

#### 🏷️ Kategori Yönetimi
1. Sol menüden "Kategori Ekle-Sil" seçin
2. Yeni kategori ekleyin veya mevcut kategorileri silin

#### ⚙️ Profil Ayarları
1. Sol menüden "Ayarlar" seçin
2. Kullanıcı adınızı değiştirin
3. Şifrenizi güncelleyin
4. Hesabınızı silin (dikkatli olun!)

---

## 📸 Ekran Görüntüleri

### Giriş Ekranı
- Modern ve kullanıcı dostu tasarım
- Kayıt ve giriş seçenekleri

![resim yüklenemedi](https://raw.githubusercontent.com/toprak-coder/StoreFlow/refs/heads/master/images/Login.png)
![resim yüklenemedi](https://raw.githubusercontent.com/toprak-coder/StoreFlow/refs/heads/master/images/Register.png)

### Dashboard
- Hoş geldin mesajı
- Hızlı erişim butonları
- Anlık saat gösterimi

![resim yüklenemedi](https://raw.githubusercontent.com/toprak-coder/StoreFlow/refs/heads/master/images/Dashboard.png)

### Ürün Yönetimi
- Ekleme, düzenleme, silme işlemleri
- DataGridView ile liste görünümü

![resim yüklenemedi](https://raw.githubusercontent.com/toprak-coder/StoreFlow/refs/heads/master/images/ÜrüneEkle.png)

![resim yüklenemedi](https://raw.githubusercontent.com/toprak-coder/StoreFlow/refs/heads/master/images/DataWiev.png)

---

## 📁 Proje Yapısı

```
magaza-uygulamas-winform--master/
│
├── LICENSE                          # MIT License
├── README.md                        # Proje dokümantasyonu
├── .gitignore                       # Git ignore kuralları
├── .gitattributes                   # Git attributes
│
├── login and register.sln           # Visual Studio solution dosyası
│
└── login and register/              # Ana proje klasörü
    │
    ├── Program.cs                   # Uygulama giriş noktası
    ├── login and register.csproj    # Proje yapılandırma dosyası
    │
    ├── appform.cs                   # Ana uygulama formu
    ├── appform.Designer.cs
    ├── appform.resx
    │
    ├── LoginForm.cs                 # Giriş formu
    ├── LoginForm.Designer.cs
    ├── LoginForm.resx
    │
    ├── RegisterForm.cs              # Kayıt formu
    ├── RegisterForm.Designer.cs
    ├── RegisterForm.resx
    │
    ├── Dashboard.cs                 # Kontrol paneli (UserControl)
    ├── Dashboard.Designer.cs
    ├── Dashboard.resx
    │
    ├── Ayarlar.cs                   # Ayarlar paneli (UserControl)
    ├── Ayarlar.Designer.cs
    ├── Ayarlar.resx
    │
    ├── KategoriEkle.cs              # Kategori yönetimi (UserControl)
    ├── KategoriEkle.Designer.cs
    ├── KategoriEkle.resx
    │
    ├── UrunEkle.cs                  # Ürün ekleme (UserControl)
    ├── UrunEkle.Designer.cs
    ├── UrunEkle.resx
    │
    ├── UrunSil.cs                   # Ürün silme (UserControl)
    ├── UrunSil.Designer.cs
    ├── UrunSil.resx
    │
    ├── UrunDuzenle.cs               # Ürün düzenleme seçici (UserControl)
    ├── UrunDuzenle.Designer.cs
    ├── UrunDuzenle.resx
    │
    ├── UrunDuzenleWinform.cs        # Ürün düzenleme formu (Form)
    ├── UrunDuzenleWinform.Designer.cs
    ├── UrunDuzenleWinform.resx
    │
    ├── UrunleriGoruntule.cs         # Ürün listeleme (UserControl)
    ├── UrunleriGoruntule.Designer.cs
    ├── UrunleriGoruntule.resx
    │
    ├── Resource1.Designer.cs        # Kaynak dosyası
    ├── Resource1.resx
    │
    ├── Properties/                  # Proje özellikleri
    │   ├── Resources.Designer.cs
    │   └── Resources.resx
    │
    └── Resources/                   # Görseller ve kaynaklar
        └── images(1).png            # Uygulama görselleri
```

### 📝 Dosya Açıklamaları

- **`.cs`** - C# kaynak kod dosyaları (iş mantığı ve event handler'lar)
- **`.Designer.cs`** - Visual Studio tarafından otomatik oluşturulan UI tasarım kodu
- **`.resx`** - Kaynak dosyaları (resimler, stringler, form özellikleri)
- **`.csproj`** - Proje yapılandırma dosyası (NuGet paketleri, referanslar, build ayarları)
- **`.sln`** - Solution dosyası (Visual Studio projesi, tüm projeleri içerir)

### 🗂️ Dosya Türleri

**Form Dosyaları:**
- `LoginForm`, `RegisterForm`, `appform`, `UrunDuzenleWinform`
- Bağımsız pencereler olarak açılır

**UserControl Dosyaları:**
- `Dashboard`, `Ayarlar`, `KategoriEkle`, `UrunEkle`, `UrunSil`, `UrunDuzenle`, `UrunleriGoruntule`
- Ana form içinde dinamik olarak yüklenir

---

## 🔧 Geliştirme Notları

### Bilinen Sorunlar (Alpha Sürümü)
- [ ] Connection string her dosyada tekrarlanıyor (merkezi yapılandırma gerekli)
- [ ] Şifre hash'leme uygulanmamış (güvenlik riski)
- [ ] Loglama sistemi yok
- [ ] Hata yönetimi geliştirilebilir
- [ ] UI/UX iyileştirmeleri yapılabilir

### Gelecek Özellikler (Roadmap)
- [ ] Uygulamaya Özel Icon
- [ ] Şifre şifreleme (BCrypt/Argon2)
- [ ] Merkezi veritabanı yapılandırması
- [ ] Stok takibi
- [ ] Fiyat yönetimi
- [ ] Satış işlemleri
- [ ] Raporlama sistemi
- [ ] Excel export/import
- [ ] Çoklu dil desteği
- [ ] Tema seçenekleri (Dark/Light)
- [ ] Yedekleme sistemi

### TODO: Dosya Yapısı Düzenleme

**Öncelikli İyileştirmeler:**

1. **Klasör Organizasyonu**
   - [ ] `Forms/` klasörü oluştur → `LoginForm`, `RegisterForm`, `appform`, `UrunDuzenleWinform` taşı
   - [ ] `UserControls/` klasörü oluştur → `Dashboard`, `Ayarlar`, `KategoriEkle`, `UrunEkle`, `UrunSil`, `UrunDuzenle`, `UrunleriGoruntule` taşı
   - [ ] `Models/` klasörü oluştur → Veri modelleri için (User, Product, Category)
   - [ ] `Services/` klasörü oluştur → İş mantığı için
   - [ ] `Data/` klasörü oluştur → Veritabanı işlemleri için
   - [ ] `Helpers/` klasörü oluştur → Yardımcı sınıflar için

2. **Yapılandırma ve Veritabanı**
   - [ ] `appsettings.json` ekle → Connection string'i buraya taşı
   - [ ] `DatabaseHelper.cs` oluştur → Merkezi veritabanı bağlantı yönetimi
   - [ ] `ConnectionManager.cs` oluştur → Connection string yönetimi
   - [ ] Tüm dosyalardaki tekrarlanan connection string'leri kaldır

3. **Kod Organizasyonu**
   - [ ] `Constants.cs` ekle → Sabit değerler (tablo adları, sütun adları, mesajlar)
   - [ ] `ValidationHelper.cs` ekle → Form validasyon fonksiyonları
   - [ ] `MessageHelper.cs` ekle → Merkezi mesaj gösterimi
   - [ ] `SecurityHelper.cs` ekle → Şifre hash'leme ve güvenlik

4. **Hedef Yapı (Örnek)**
   ```
   login and register/
   ├── Program.cs
   ├── Forms/
   │   ├── LoginForm.cs
   │   ├── RegisterForm.cs
   │   ├── appform.cs
   │   └── UrunDuzenleWinform.cs
   ├── UserControls/
   │   ├── Dashboard.cs
   │   ├── Ayarlar.cs
   │   └── ...
   ├── Models/
   │   ├── User.cs
   │   ├── Product.cs
   │   └── Category.cs
   ├── Services/
   │   ├── UserService.cs
   │   ├── ProductService.cs
   │   └── CategoryService.cs
   ├── Data/
   │   ├── DatabaseHelper.cs
   │   └── ConnectionManager.cs
   ├── Helpers/
   │   ├── Constants.cs
   │   ├── ValidationHelper.cs
   │   ├── MessageHelper.cs
   │   └── SecurityHelper.cs
   ├── Properties/
   ├── Resources/
   └── appsettings.json
   ```

---

## 🤝 Katkıda Bulunma

Katkılarınızı bekliyoruz! Projeye katkıda bulunmak için:

1. Bu repository'yi fork edin
2. Yeni bir branch oluşturun (`git checkout -b feature/YeniOzellik`)
3. Değişikliklerinizi commit edin (`git commit -m 'Yeni özellik eklendi'`)
4. Branch'inizi push edin (`git push origin feature/YeniOzellik`)
5. Pull Request oluşturun

### Kod Standartları
- C# coding conventions'ları takip edin
- Anlamlı commit mesajları yazın
- Kod yorumlarını Türkçe veya İngilizce ekleyin
- Test edilmiş kod gönderin

---

## 📞 İletişim

**Geliştirici:** Toprak  
**GitHub:** [@toprak-coder](https://github.com/toprak-coder)  
**Twitter/X:** [@Psikoz_Coder](https://x.com/Psikoz_Coder)

---

## 📄 Lisans

Bu proje [MIT License](LICENSE) altında lisanslanmıştır.

**MIT License** ile:
- ✅ Ticari kullanım yapabilirsiniz
- ✅ Kodu değiştirebilir ve dağıtabilirsiniz
- ✅ Özel projelerinizde kullanabilirsiniz
- ✅ Lisans ve telif hakkı bildirimini korumanız yeterlidir

Detaylar için [LICENSE](LICENSE) dosyasına bakın.

---

## 🙏 Teşekkürler

- **ReaLTaiizor** - Modern UI bileşenleri için
- **Syncfusion** - Chart ve görselleştirme araçları için
- **Microsoft** - .NET Framework ve SQL Server için

---

## 📝 Sürüm Geçmişi

### Alpha 1.0.0 (Mevcut)
- ✅ Temel kullanıcı yönetimi
- ✅ Ürün CRUD işlemleri
- ✅ Kategori yönetimi
- ✅ Dashboard
- ✅ Ayarlar paneli
- ✅ Modern UI tasarımı

---

## ⚠️ Önemli Notlar

1. **Güvenlik**: Bu alpha sürümde şifreler düz metin olarak saklanmaktadır. Üretim ortamında kullanmayın!
2. **Veritabanı**: Connection string'leri güncellemeden önce SQL Server'ınızın çalıştığından emin olun.
3. **Yedekleme**: Önemli verilerinizi düzenli olarak yedekleyin.
4. **Test**: Uygulamayı üretim ortamında kullanmadan önce test ortamında deneyin.

---

**StoreFlow** - Mağaza yönetimini kolaylaştırın! 🚀

*Bu proje aktif geliştirme aşamasındadır. Geri bildirimleriniz ve önerileriniz için GitHub Issues kullanabilirsiniz.*
