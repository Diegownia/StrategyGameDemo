using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StrategyGameDemo;

internal class Program
{
    public static void Main(string[] args)
    {
        Runner().Build();
    }

    private static HostApplicationBuilder Runner()
    {
        var builder = Microsoft.Extensions.Hosting.Host.CreateApplicationBuilder();
        builder.Services.AddSingleton<Config>();

        return builder;
    }
}
