using AkplusUret�mSiparisWebApp.Data;  // AppDbContext i�in gerekli
using Microsoft.EntityFrameworkCore;    // UseSqlServer i�in gerekli

var builder = WebApplication.CreateBuilder(args);

// ???? AppDbContext hizmet olarak tan�t�l�yor
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Di�er servisler
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
