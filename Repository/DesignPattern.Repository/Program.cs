using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.BusinessLayer.Concrete;
using RepositoryDesignPattern.DataAccessLayer.Abstract;
using RepositoryDesignPattern.DataAccessLayer.Concrete;
using RepositoryDesignPattern.DataAccessLayer.EntityFramework;

namespace DesignPattern.Repository
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<ICategoryService, CategoryManager>();
            builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
            builder.Services.AddScoped<IProductService, ProductManager>();
            builder.Services.AddScoped<IProductDal, EfProductDal>();

            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddControllersWithViews();

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