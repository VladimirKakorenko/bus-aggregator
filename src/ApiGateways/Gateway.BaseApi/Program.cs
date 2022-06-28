namespace Web.Bus.HttpAggregator;

public class Program
{
    public static void Main(string[] args)
    {
        IWebHostBuilder builder = new WebHostBuilder();

        builder
            .ConfigureServices(s =>
            {
                s.AddSingleton(builder);
            })
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddConsole();
                logging.SetMinimumLevel(LogLevel.Information);
            })
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseStartup<Startup>();

        var host = builder.Build();
        host.Run();
    }
}