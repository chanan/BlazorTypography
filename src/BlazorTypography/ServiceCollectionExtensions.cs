﻿using BlazorStyled;
using BlazorTypography.Internal;
using Microsoft.Extensions.DependencyInjection;
using Polished;

namespace BlazorTypography
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTypography(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddBlazorStyled(isDevelopment: true);
            serviceCollection.AddTransient<BlazorTypographyInterop>();
            serviceCollection.AddTransient<ITypography, Typography>();
            serviceCollection.AddSingleton<IMixins, Mixins>();
            return serviceCollection;
        }
    }
}