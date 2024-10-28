using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// 1. MVC servislerini ekleyin.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 2. Statik dosyalar�n kullan�labilir olmas� i�in gerekli ayar.
app.UseStaticFiles();

// 3. Routing yap�land�rmas�
app.UseRouting();

// 4. Varsay�lan routing ayarlar�
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();

// Controllers: Uygulaman�n y�nlendirme (route) mant���yla kullan�c� isteklerini kar��layan s�n�flard�r.

// Action: Controller i�inde tan�mlanm�� metotlard�r ve her biri belirli bir g�revi yerine getirir.

// Model: Uygulamadaki verileri temsil eden yap�lard�r, veri yap�lar�n�n tan�mland��� s�n�flar� i�erir.

// View: Kullan�c�ya g�sterilecek g�r�n�mleri temsil eder; Razor syntax ile yaz�l�r.

// Razor: Dinamik HTML i�eri�i olu�turmak i�in kullan�lan .cshtml dosyalar�nda kullan�lan syntax'tir.

// RazorView: Razor syntax ile yaz�lan view dosyalar�d�r (.cshtml).

// wwwroot: Uygulamadaki statik dosyalar�n tutuldu�u klas�rd�r (CSS, JS, resimler gibi).


// builder.Build(): Builder nesnesi �zerinden uygulamay� yap�land�rmak ve bir web uygulamas� instance'� olu�turmak i�in kullan�l�r.

// app.Run(): Yap�land�r�lan uygulamay� �al��t�r�r; uygulama i�lemi bu noktayla ba�lar.


