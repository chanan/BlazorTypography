using BlazorStyled;
using Microsoft.AspNetCore.Components.Builder;
using System;
using System.Collections.Generic;
using System.Text;

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
