

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Models;

namespace MVC.Configurations
{
    public static class DbMigrationHelperExtension
    {
        
        public static void UseDbMigrationHelper(this WebApplication app)
        {
            DbMigrationHelpers.EnsureSeedData(app).Wait();
        }
    }

    public static class DbMigrationHelpers
    {
        public static Guid Vendedorid = Guid.NewGuid();
        public static async Task EnsureSeedData(WebApplication serviceScope)
        {
            var services = serviceScope.Services.CreateScope().ServiceProvider;
            await EnsureSeedData(services);
        }

        public static async Task EnsureSeedData(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var env = scope.ServiceProvider.GetRequiredService<IWebHostEnvironment>();

            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            var contextId = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            if (env.IsDevelopment() || env.IsEnvironment("Docker") || env.IsStaging())
            {
                await context.Database.MigrateAsync();
                await contextId.Database.MigrateAsync();

                await EnsureSeedProducts(context, contextId);
            }
        }

        private static async Task EnsureSeedProducts(AppDbContext context, AppDbContext contextId)
        {           
            if (context.Produtos.Any())
                return;

            await context.Produtos.AddAsync(new Produto()
            {
                Nome = "Livro CSS",
                Preco = 50,
                Descricao = "Teste",
                VendedorId = Vendedorid,
            });

            await context.Produtos.AddAsync(new Produto()
            {
                Nome = "Livro jQuery",
                Preco = 150,
                Descricao = "Teste",                                
                VendedorId = Vendedorid
            });

            await context.Categorias.AddAsync(new Categoria()
            {
                Descricao = "Teste",
                Id = 1,
            });
            await context.Categorias.AddAsync(new Categoria()
            {
                Descricao = "Teste2",
                Id =2,
            });
            await context.Produtos.AddAsync(new Produto()
            {
                Nome = "Livro HTML",
                Preco = 90,
                Descricao = "Teste",
                
            });

            await context.Produtos.AddAsync(new Produto()
            {
                Nome = "Livro Razor",
                Preco = 50,
                Descricao = "Teste",                             
                VendedorId = Vendedorid
            });
            await context.Vendedores.AddAsync(new Vendedor()
            {
               Email = "teste@teste.com",
                Id = Vendedorid,
                Nome = "Vendedor 1",                

            });

            await context.SaveChangesAsync();

            if (contextId.Users.Any())
                return;

            await contextId.Users.AddAsync(new IdentityUser
            {
                Id = Vendedorid.ToString(),
                UserName = "teste@teste.com",
                NormalizedUserName = "TESTE@TESTE.COM",
                Email = "teste@teste.com",
                NormalizedEmail = "TESTE@TESTE.COM",
                AccessFailedCount = 0,
                LockoutEnabled = false,
                PasswordHash = "AQAAAAIAAYagAAAAEEdWhqiCwW/jZz0hEM7aNjok7IxniahnxKxxO5zsx2TvWs4ht1FUDnYofR8JKsA5UA==",
                TwoFactorEnabled = false,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            });

            await contextId.SaveChangesAsync();  
            
        }
    }
}
