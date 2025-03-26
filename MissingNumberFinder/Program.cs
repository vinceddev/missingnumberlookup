using MissingNumberFinder.Services.Core;
using MissingNumberFinder.Services.Input;
using MissingNumberFinder.Services.Output;
using MissingNumberFinder.Services.Validation;
using MissingNumberFinder.Services.Utils;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MissingNumberFinder.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();
        var app = host.Services.GetRequiredService<MissingNumberApp>();
        app.Run();
    }

    static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    // Register dependencies
                    services.AddTransient<IInputReader, ConsoleInputReader>();
                    services.AddTransient<IInputParser, CommaSeparatedParser>();
                    services.AddTransient<IInputValidator, InputValidator>();
                    services.AddTransient<IMissingNumberLookup, MissingNumberLookup>();
                    services.AddTransient<IOutputWriter, ConsoleOutputWriter>();

                    // Register main app
                    services.AddTransient<MissingNumberApp>();
                });
}