using BlazorTypography.Fonts;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BlazorTypography
{
    public class Typography : ComponentBase
    {
        [Parameter] private string Theme { get; set; }
        [Parameter] private string BaseFontSize { get; set; } = "16px";
        [Parameter] private string BaseLineHeight { get; set; } = "1.45";
        [Parameter] private double? ScaleRatio { get; set; }
        [Parameter] private string HeaderColor { get; set; } = "inherit";
        [Parameter] private string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        [Parameter] private string HeaderWeight { get; set; } = "bold";
        [Parameter] private string BodyWeight { get; set; } = "normal";
        [Parameter] private string BoldWeight { get; set; } = "bold";
        [Parameter] private string BlockMarginBottom { get; set; } = "1";
        [Parameter] private bool? IncludeNormalize { get; set; }
        [Parameter] private string GoogleFonts { get; set; }
        [Parameter] private string HeaderFontFamily { get; set; } = "-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif";
        [Parameter] private string BodyFontFamily { get; set; } = "georgia,serif";
        [Parameter] private string Plugins { get; set; }

        [Inject] private ITypography TypographyService { get; set; }

        private static readonly FontManager _fontManager = new FontManager();

        protected override void OnInit()
        {
            ITypographyOptions themeClass = Theme != null ? TypographyService.ThemeForName(Theme) : new DefaultTypographyOptions();
            if(themeClass == null)
            {
                themeClass = new DefaultTypographyOptions();
            }
            if(BaseFontSize != "16px")
            {
                themeClass.BaseFontSize = BaseFontSize;
            }
            if (BaseLineHeight != "1.45")
            {
                themeClass.BaseLineHeight = BaseLineHeight;
            }
            if(ScaleRatio.HasValue)
            {
                themeClass.ScaleRatio = ScaleRatio;
            }
            if(HeaderColor != "inherit")
            {
                themeClass.HeaderColor = HeaderColor;
            }
            if(BodyColor != "hsla(0,0%,0%,0.8)")
            {
                themeClass.BodyColor = BodyColor;
            }
            if (HeaderWeight != "bold")
            {
                themeClass.HeaderWeight = HeaderWeight;
            }
            if (BodyWeight != "normal")
            {
                themeClass.BodyWeight = BodyWeight;
            }
            if (BoldWeight != "bold")
            {
                themeClass.BoldWeight = BoldWeight;
            }
            if(BlockMarginBottom != "1")
            {
                themeClass.BlockMarginBottom = BlockMarginBottom;
            }
            if(IncludeNormalize.HasValue)
            {
                themeClass.IncludeNormalize = IncludeNormalize;
            }
            if(HeaderFontFamily != "-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif")
            {
                List<string> headerFontFamily = HeaderFontFamily.Split(',').ToList();
                themeClass.HeaderFontFamily = headerFontFamily;
            }
            if(BodyFontFamily != "georgia,serif")
            {
                List<string> bodyFontFamily = BodyFontFamily.Split(',').ToList();
                themeClass.BodyFontFamily = bodyFontFamily;
            }
            if(Plugins != null)
            {
                //For now, plugins are in the Plugins namespace, but in the future they could be external
                themeClass.Plugins = new List<IPlugin>();
                string[] plugins = Plugins.Split(',');
                foreach(string pluginname in plugins)
                {
                    IPlugin plugin = PluginForName(pluginname);
                    if(plugin != null)
                    {
                        themeClass.Plugins.Add(plugin);
                    }
                }
            }


            //Load all styles of the listed fonts
            if(!string.IsNullOrWhiteSpace(GoogleFonts))
            {
                if (themeClass.GoogleFonts == null) themeClass.GoogleFonts = new List<GoogleFont>();
                string[] fonts = GoogleFonts.Split(',');
                foreach(string fontname in fonts)
                {
                    Font font = GetFont(fontname.Trim());
                    if (font == null) continue;
                    List<string> styles = font.Weights.Select(w =>
                    {
                        w = w.Replace("regular", "400");
                        if(w == "italic")
                        {
                            w = "400i";
                        }
                        w = w.Replace("italic", "i");
                        return w;
                    }).ToList();
                    GoogleFont gf = new GoogleFont
                    {
                        Name = font.Family,
                        Styles = styles
                    };
                    themeClass.GoogleFonts.Add(gf);
                }
            }
            TypographyService.ApplyTypography(themeClass);
        }

        private Font GetFont(string font)
        {
            return _fontManager.Fonts.SingleOrDefault(f => f.Family == font);
        }

        private IPlugin PluginForName(string name)
        {
            IPlugin plugin = null;
            List<TypeInfo> plugins = (from type in Assembly.GetAssembly(typeof(IPlugin)).DefinedTypes
                                     where type.ImplementedInterfaces.Contains(typeof(IPlugin))
                                     select type).ToList();

            foreach (TypeInfo type in plugins)
            {
                if (GetTitle(type).ToLower() == name.ToLower())
                {
                    plugin = (IPlugin)Activator.CreateInstance(type, null);
                    break;
                }
            }
            return plugin;
        }

        private string GetTitle(TypeInfo type)
        {
            PropertyInfo prop = type.GetProperty("Title");
            return (string)prop.GetGetMethod().Invoke(Activator.CreateInstance(type, null), null);
        }
    }
}
