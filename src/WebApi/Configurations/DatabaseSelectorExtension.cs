
using WebApi.Data;

using Microsoft.EntityFrameworkCore;

namespace MVC.Configurations
{
    public static class DatabaseSelectorExtension
    {
        public static void AddDatabaseSelector(this WebApplicationBuilder builder)
        {
            if (builder.Environment.IsDevelopment())
            {
                builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnectionLite")));

                builder.Services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnectionLite")));
            }
            else
            {
                builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

                builder.Services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            }

        }
    }
}
