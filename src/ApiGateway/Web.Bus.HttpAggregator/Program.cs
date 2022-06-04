using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace Web.Bus.HttpAggregator;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IWebHostBuilder CreateHostBuilder(string[] args)
    {
        var builder = new WebHostBuilder();

        builder
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .ConfigureAppConfiguration((hostingContext, c) =>
            {
                c.AddJsonFile("appsettings", true, true)
                    .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", true, true)
                    .AddJsonFile(Path.Combine("Configuration", "configuration.json"));
            })
            .ConfigureServices(s =>
            {
                s.AddOcelot();
            })
            .Configure(app =>
            {
                app.UseOcelot().Wait();
            });

        return builder;
    }
}