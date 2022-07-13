using DbUp;

using System.Reflection;

namespace Services.Catalog.API.Extensions;

public static class DatabaseExtensions
{
    public static IHost MigrateDatabase(this IHost host)
    {
        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var configuration = services.GetRequiredService<IConfiguration>();

            var connectionString = configuration.GetConnectionString("SqlLocal");

            EnsureDatabase.For.SqlDatabase(connectionString);

            var upgrader = DeployChanges.To
                .SqlDatabase(connectionString)
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                .LogToConsole()
                .Build();

            var result = upgrader.PerformUpgrade();

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Database updated: " + result.Successful);
            Console.WriteLine("-----------------------------------------");

            return host;
        }
    }
}