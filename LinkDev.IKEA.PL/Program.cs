using LinkDev.IKEA.BLL.Services.DepartmentServices;
using LinkDev.IKEA.DAL.Data;
using LinkDev.IKEA.DAL.Enteties.Department;
using LinkDev.IKEA.DAL.Repositories.DepartmentRepo;
using Microsoft.EntityFrameworkCore;

namespace LinkDev.IKEA.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Configure Services

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            builder.Services.AddDbContext<ApplicationDbContext>
                (
                  options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
                );

                builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
                 builder.Services.AddScoped<IDepartmentServices, DepartmentService>();

            #endregion

            #region Configure Kestrle MiddleWares

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
            #endregion

            app.Run();
        }
    }
}
