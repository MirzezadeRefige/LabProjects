using Microsoft.EntityFrameworkCore;
using Pronia.BL.Services.Abstractions;
using Pronia.BL.Services.Concretes;
using Pronia.DAL.Contexts;
// void ConfigureServices(IServiceCollection services)
//{
//    // DbContext-i qeyd edirik
//    services.AddDbContext<ProniaDbContext>(opt =>
//        opt.UseSqlServer("SizinBaðlantýStringiniz"));
//}
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
string? connectionStr = builder.Configuration.GetConnectionString("MSSql");
builder.Services.AddDbContext<ProniaDbContext>(opt =>
opt.UseSqlServer(connectionStr)
);


builder.Services.AddScoped<ISliderItemService, SliderItemService>();
var app = builder.Build();
app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
          );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
app.UseStaticFiles();   
app.Run();
