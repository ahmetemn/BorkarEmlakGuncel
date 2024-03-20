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
                ).AddEntityFrameworkStores<ApplicationContext>(); //contexteki ozellikleri de dahil etmesi için eklenmesi gerekiyor.
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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}