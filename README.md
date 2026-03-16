# 🛒 YumBlazor – Blazor ile E-Ticaret Uygulaması

**YumBlazor**, modern web teknolojileri kullanılarak geliştirilmiş bir **e-ticaret web uygulamasıdır**.  
Proje **Blazor ve .NET** kullanılarak geliştirilmiş olup kullanıcı yönetimi, ürün listeleme, alışveriş sepeti ve ödeme işlemleri gibi temel e-ticaret özelliklerini içermektedir.

Bu proje, **Blazor ile gerçek dünya uygulaması geliştirme pratiği yapmak** amacıyla geliştirilmiştir.

---

# 🚀 Features

## 🔐 Authentication & Authorization
- Kullanıcı kayıt ve giriş sistemi
- Rol tabanlı yetkilendirme
- External login (Google, Microsoft, Facebook)

## 🛍 Product Management
- Ürün listeleme
- Ürün ekleme, güncelleme ve silme
- Ürün detay sayfası

## 🛒 Shopping Cart
- Sepete ürün ekleme
- Sepetten ürün çıkarma
- Sepet toplam fiyat hesaplama

## 📦 Order Management
- Sipariş oluşturma
- Sipariş geçmişi görüntüleme
- Sipariş detay sayfası

## 💳 Payment Integration
- Stripe ile güvenli ödeme sistemi

## 🔔 Notifications
- Toastr bildirimleri ile kullanıcı geri bildirimleri

---

# 🛠️ Technologies Used

- .NET
- Blazor
- Entity Framework Core
- SQL Server
- .NET Identity
- Bootstrap 5
- Stripe Payment API
- Toastr.js
- LINQ
- Repository Pattern
- Dependency Injection

---

# ⚙️ Getting Started

## 1️⃣ Clone the repository

git clone https://github.com/kbravrl/YumBlazor.git
cd YumBlazor

---

## 2️⃣ Configure the Database

appsettings.json dosyasında connection string ayarlayın:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=YumBlazorDB;Trusted_Connection=True;"
}

---

## 3️⃣ Run Migrations

dotnet ef database update

---

## 4️⃣ Run the Application

dotnet run
