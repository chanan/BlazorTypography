using BlazorPrettyCode;
using BlazorTypography;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SamplePages;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Sample
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);

            //Configure Services
            builder.Services.AddTypography();
            builder.Services.AddBlazorPrettyCode(config =>
            {
                config.ShowLineNumbers = true;
                config.DefaultTheme = "SolarizedLight";
            });
            //End Configure Services

            builder.Services.AddScoped(sp => new HttpClient{ BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.RootComponents.Add<App>("#app");

            await builder.Build().RunAsync();
        }
    }
}
