# 🛒 YumBlazor – Blazor ile E-Ticaret Uygulaması

**YumBlazor**, modern web teknolojileri kullanılarak geliştirilmiş bir e-ticaret web uygulamasıdır.  
Proje **Blazor ve .NET** kullanılarak geliştirilmiş olup kullanıcı yönetimi, ürün listeleme, alışveriş sepeti ve ödeme işlemleri gibi temel e-ticaret özelliklerini içermektedir.

Bu proje, Blazor ile gerçek dünya uygulaması geliştirme pratiği yapmak amacıyla geliştirilmiştir.

---

# 🚀 Özellikler

## 🔐 Kimlik Doğrulama ve Yetkilendirme
- Kullanıcı kayıt ve giriş sistemi
- Rol tabanlı yetkilendirme
- Harici giriş sağlayıcıları (Google, Microsoft, Facebook)

## 🛍 Ürün Yönetimi
- Ürün listeleme
- Ürün ekleme, güncelleme ve silme
- Ürün detay sayfası

## 🛒 Alışveriş Sepeti
- Sepete ürün ekleme
- Sepetten ürün çıkarma
- Sepet toplam tutarını hesaplama

## 📦 Sipariş Yönetimi
- Sipariş oluşturma
- Sipariş geçmişini görüntüleme
- Sipariş detaylarını görüntüleme

## 💳 Ödeme Entegrasyonu
- Stripe ile güvenli ödeme sistemi

## 🔔 Bildirimler
- Toastr bildirimleri ile kullanıcı geri bildirimleri

---

# 🛠 Kullanılan Teknolojiler

- .NET
- Blazor
- Entity Framework Core
- PostgreSQL
- .NET Identity
- Bootstrap 5
- Stripe Payment API
- Toastr.js
- LINQ
- Repository Pattern
- Dependency Injection

---

# ⚙️ Kurulum

## 1️⃣ Projeyi klonla

git clone https://github.com/kbravrl/YumBlazor.git  

---

## 2️⃣ Veritabanını yapılandır

`appsettings.json` dosyasında connection string ayarını düzenleyin:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=YumBlazorDB;Trusted_Connection=True;"
}

---

## 3️⃣ Migration çalıştır

dotnet ef database update

---

## 4️⃣ Uygulamayı çalıştır

dotnet run
