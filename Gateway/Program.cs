using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace Gateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Configuration.AddJsonFile("configuration.json");
            builder.Services.AddOcelot();
            var app = builder.Build();
            app.UseOcelot().Wait();
            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}