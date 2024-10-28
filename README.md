# Pratik - ASP.NET Core Empty

Bu proje, temel bir **ASP.NET Core Empty** proje şablonundan yola çıkarak **MVC yapısına** uygun hale getirilmiştir. Aşağıdaki adımları ve yapılandırmaları içermektedir.

## Proje Yapısı

- **Controllers**: `Controllers` klasörü, uygulamanın yönlendirme (routing) işlemlerini yöneten controller sınıflarını içerir.
- **Models**: `Models` klasörü, verileri temsil eden sınıfları içerir.
- **Views**: `Views` klasörü, kullanıcıya gösterilecek görünümleri (HTML sayfalarını) barındırır.
- **wwwroot**: `wwwroot` klasörü, CSS, JavaScript ve resim gibi statik dosyalar için kullanılır.

## Yapılandırma Detayları

1. **MVC Servislerinin Eklenmesi**: `Program.cs` dosyasında MVC servisleri eklenmiştir.
2. **Statik Dosya Kullanımı**: `wwwroot` klasöründe bulunan statik dosyaların kullanılabilmesi için gerekli ayarlar yapılmıştır.
3. **Routing Konfigürasyonu**: Varsayılan routing yapılandırması, `HomeController` içindeki `Index` action'ına yönlendirecek şekilde ayarlanmıştır.
