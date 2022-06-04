using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;

namespace Web.Bus.HttpAggregator;

public class Startup
{
    public Startup(IHostingEnvironment env)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "Configuration", "configuration.json"), optional: false, reloadOnChange: true)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables();

        Configuration = builder.Build();
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddOcelot(Configuration);
        services.AddHealthChecks()
            .AddCheck("self", () => HealthCheckResult.Healthy())
            .AddUrlGroup(new Uri(Configuration["AdapterUrlHC"]), "adapter-apicheck", tags: new string[] { "adapterapi" })
            .AddUrlGroup(new Uri(Configuration["DataUrlHC"]), "data-apicheck", tags: new string[] { "dataapi" })
            .AddUrlGroup(new Uri(Configuration["WebSpaUrlHC"]), "web-spacheck", tags: new string[] { "webspa" });
    }

    public async void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapHealthChecks("/hc", new HealthCheckOptions()
            {
                Predicate = _ => true,
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });

            endpoints.MapHealthChecks("/liveness", new HealthCheckOptions()
            {
                Predicate = r => r.Name.Contains("self")
            });
        });

        await app.UseOcelot();
    }
}
