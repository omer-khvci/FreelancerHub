# FreelancerHub
# 🚀 FreelancerHub

FreelancerHub, freelance çalışanlar ile işverenleri bir araya getiren ve proje teklif süreçlerini yöneten bir açık kaynak .NET Core Web API uygulamasıdır.

## 🎯 Projenin Amacı

Bu proje, freelancer çalışanların:
- Projeleri keşfetmesini,
- Projelere teklif vermesini,
- Kendi hesaplarını yönetmesini,

ve işverenlerin:
- Yeni projeler oluşturmasını,
- Gelen teklifleri incelemesini,

sağlayan modüler ve genişletilebilir bir backend mimarisi sunar.

--------------------------------------------------------------------------------------------------------------------------------------------------------------

## 🛠️ Kullanılan Teknolojiler

- .NET 9
- Entity Framework Core
- PostgreSQL
- Swagger / Swashbuckle
- Generic Repository Pattern
- Onion Architecture (katmanlı yapı)
- JetBrains Rider IDE 💻

----------------------------------------------------------------------------------------------------------------------------------------------------------------

## ⚙️ Kurulum

1. Proje klasörüne terminal ile gel ve bağımlılıkları yükle:

   ```bash
   dotnet restore

   "ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Database=freelancerhubdb;Username=postgres;Password=yourpassword"
}

dotnet ef migrations add InitialCreate -p FreelancerHub.Infrastructure -s FreelancerHub.API

dotnet run --project FreelancerHub.API
https://localhost:5001/swagger

FreelancerHub/
├── FreelancerHub.API              # Web API katmanı
├── FreelancerHub.Core             # Domain, Entity, Interface katmanı
├── FreelancerHub.Infrastructure   # Veritabanı ve repository işlemleri
----------------------------------------------------------------------------------------------------------------------------------------------------------------
🧩 Mevcut Özellikler
 Kullanıcı modeli (User)

 Proje modeli (Project)

 Teklif modeli (Proposal)

 PostgreSQL desteği

 EF Core ile migration ve database update

 Swagger UI ile API test ortamı

 JWT tabanlı kimlik doğrulama

 Rol bazlı yetkilendirme

 Frontend arayüz (opsiyonel)

---------------------------------------------------------------------------------------------------------------------------------------------------------------
 🤝 Katkı Sağlamak
Pull request’ler, feature branch’ler ve öneriler her zaman memnuniyetle karşılanır.
git checkout -b feature/yeniozellik
