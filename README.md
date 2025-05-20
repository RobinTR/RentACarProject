Bu proje, araç kiralama işlemlerini yönetmek için geliştirilmiş bir .NET uygulamasıdır. Katmanlı mimari kullanılarak tasarlanmış olup, aşağıdaki ana katmanlardan oluşmaktadır:

- **Entities**: Temel varlık ve DTO sınıflarını içerir.
- **DataAccess**: Veritabanı işlemleri için Entity Framework Core kullanılmıştır.
- **Business**: İş kuralları, servisler ve validasyonlar burada yer alır. FluentValidation ve Autofac ile bağımlılık enjeksiyonu sağlanmıştır.
- **Core**: Ortak altyapı kodları ve yardımcı sınıflar bulunur.
- **WebAPI**: RESTful servisler, JWT kimlik doğrulama ve Swagger dokümantasyonu içerir.
- **ConsoleUI**: Konsol tabanlı test uygulamasıdır.

## Kullanılan Teknolojiler

- .NET 6 (C#)
- Entity Framework Core
- Autofac (Bağımlılık Enjeksiyonu)
- FluentValidation
- JWT Authentication
- Swagger (Swashbuckle)
