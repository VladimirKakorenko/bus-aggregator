namespace WebStatus;

public class Program
{
    public static Task Main(string[] args)
    {
        return BuildWebHost(args).Build().RunAsync();
    }

    public static IHostBuilder BuildWebHost(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .UseContentRoot(Directory.GetCurrentDirectory())
            .ConfigureWebHostDefaults(builder =>
            {
                builder.UseStartup<Startup>();
            });
    }
}