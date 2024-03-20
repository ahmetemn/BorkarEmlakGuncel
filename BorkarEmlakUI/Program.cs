using BorkarEmlak.DATA.Concrate;
using BorkarEmlak.REPO.Context;

namespace BorkarEmlakUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ApplicationContext>();
            builder.Services.AddIdentity<AppUser, AppRole>(
                ).AddEntityFrameworkStores<ApplicationContext>(); //contexteki ozellikleri de dahil etmesi i�in eklenmesi gerekiyor.
            builder.Services.ConfigureApplicationCookie(
                option =>
                {
                    option.LoginPath = "/Auth/Login";
                }
            );
            // Add services to the container.
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
            app.MapAreaControllerRoute(

               name: "Admin",
               areaName: "Admin",
               pattern: "Admin/{controller=AdminPanel}/{action=AdminSayfasi}/{id?}"


               );
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}