using BlazorStyled;
using Microsoft.AspNetCore.Components.Builder;

namespace BlazorTypography
{
    public static class ComponentsApplicationBuilderExtensions
    {
        public static IComponentsApplicationBuilder AddClientSideTypography(this IComponentsApplicationBuilder componentsApplicationBuilder)
        {
            componentsApplicationBuilder.AddComponent<ClientSideStyled>("#styled");
            return componentsApplicationBuilder;
        }
    }
}
