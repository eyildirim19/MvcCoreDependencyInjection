using MvcCoreDependencyInjection.Models;

var builder = WebApplication.CreateBuilder(args);

// DI b�l�m�
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<MYCLASS>();
builder.Services.AddScoped<IInsan, Ogrenci>();

// Middleware b�l�m�

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
