using BackendProje.Data.Abstract;
using BackendProje.Data.Concrete.EFCore;
using BackendProje.Data.Concrete.EFCore.Context;
using Microsoft.EntityFrameworkCore;
namespace BackendProje.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<BackEndContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

            builder.Services.AddScoped<IProductRepository, EfCoreProductRepository>();
            builder.Services.AddScoped<IOrderRepository, EfCoreOrderRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }



            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}