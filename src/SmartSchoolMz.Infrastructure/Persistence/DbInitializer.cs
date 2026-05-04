using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmartSchoolMz.Domain.Entities;

namespace SmartSchoolMz.Infrastructure.Persistence;

public static class DbInitializer
{
    public static async Task Initialize(IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

        // Apply migrations
        await context.Database.MigrateAsync();

        // Seed Roles
        string[] roles = { "Admin", "Professor", "Encarregado", "Aluno" };
        foreach (var role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }
        }

        // Seed Admin User
        var adminEmail = "admin@smartschool.mz";
        var adminUser = await userManager.FindByEmailAsync(adminEmail);
        if (adminUser == null)
        {
            adminUser = new IdentityUser
            {
                UserName = adminEmail,
                Email = adminEmail,
                EmailConfirmed = true
            };
            await userManager.CreateAsync(adminUser, "Admin123!");
            await userManager.AddToRoleAsync(adminUser, "Admin");
        }

        // Seed Year
        if (!context.AnosLectivos.Any())
        {
            var ano = new AnoLetivo
            {
                Ano = DateTime.Now.Year,
                Activo = true,
                DataInicio = new DateTime(DateTime.Now.Year, 1, 1),
                DataFim = new DateTime(DateTime.Now.Year, 12, 31)
            };
            context.AnosLectivos.Add(ano);
            await context.SaveChangesAsync();
        }

        // Seed Classes
        if (!context.Classes.Any())
        {
            context.Classes.AddRange(
                new Classe { Nome = "10ª Classe", Nivel = "Secundário", ValorMensalidade = 1500 },
                new Classe { Nome = "11ª Classe", Nivel = "Secundário", ValorMensalidade = 2000 },
                new Classe { Nome = "12ª Classe", Nivel = "Secundário", ValorMensalidade = 2500 }
            );
            await context.SaveChangesAsync();
        }
    }
}
