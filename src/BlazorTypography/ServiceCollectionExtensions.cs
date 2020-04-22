using BlazorStyled;
using BlazorTypography.Internal;
using Microsoft.Extensions.DependencyInjection;
using Polished;

namespace BlazorTypography
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTypography(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddBlazorStyled(isDevelopment: true, isDebug: true);
            serviceCollection.AddTransient<ITypography, TypographyImpl>();
            serviceCollection.AddSingleton<IMixins, Mixins>();
            return serviceCollection;
        }
    }
}