﻿using BlazorPrettyCode;
using BlazorStyled;
using BlazorTypography;
using Microsoft.AspNetCore.Blazor.Hosting;
using SamplePages;
using System.Threading.Tasks;

namespace Sample
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            //Configure Services
            builder.Services.AddTypography();
            builder.Services.AddBlazorPrettyCode(config =>
            {
                config.ShowLineNumbers = true;
                config.DefaultTheme = "SolarizedLight";
            });

            //End Configure Services

            builder.RootComponents.Add<App>("app");

            //Add BlazorStyled to root components
            builder.RootComponents.Add<ClientSideStyled>("#styled");

            await builder.Build().RunAsync();
        }
    }
}
