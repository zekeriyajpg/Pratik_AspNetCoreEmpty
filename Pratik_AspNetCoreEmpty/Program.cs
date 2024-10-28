using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// 1. MVC servislerini ekleyin.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 2. Statik dosyalarýn kullanýlabilir olmasý için gerekli ayar.
app.UseStaticFiles();

// 3. Routing yapýlandýrmasý
app.UseRouting();

// 4. Varsayýlan routing ayarlarý
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();

// Controllers: Uygulamanýn yönlendirme (route) mantýðýyla kullanýcý isteklerini karþýlayan sýnýflardýr.

// Action: Controller içinde tanýmlanmýþ metotlardýr ve her biri belirli bir görevi yerine getirir.

// Model: Uygulamadaki verileri temsil eden yapýlardýr, veri yapýlarýnýn tanýmlandýðý sýnýflarý içerir.

// View: Kullanýcýya gösterilecek görünümleri temsil eder; Razor syntax ile yazýlýr.

// Razor: Dinamik HTML içeriði oluþturmak için kullanýlan .cshtml dosyalarýnda kullanýlan syntax'tir.

// RazorView: Razor syntax ile yazýlan view dosyalarýdýr (.cshtml).

// wwwroot: Uygulamadaki statik dosyalarýn tutulduðu klasördür (CSS, JS, resimler gibi).


// builder.Build(): Builder nesnesi üzerinden uygulamayý yapýlandýrmak ve bir web uygulamasý instance'ý oluþturmak için kullanýlýr.

// app.Run(): Yapýlandýrýlan uygulamayý çalýþtýrýr; uygulama iþlemi bu noktayla baþlar.


