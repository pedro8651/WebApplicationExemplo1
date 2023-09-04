using Microsoft.EntityFrameworkCore;
using WebApplicationExemplo1.Data;

namespace WebApplicationExemplo1
{
    public class Startup{
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var _mySQLServerVersion = new MySqlServerVersion(new Version(8, 0, 33));

            services.AddDbContext<ApplicationDbContext>(
                                    options => options.UseMySql(
                                                        Configuration.GetConnectionString("ApplicationDbContext"),
                                                        _mySQLServerVersion
                                                    )
                                    );

            services.AddRazorPages();
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapRazorPages();

            app.Run();
        }
    }
}
