using BlazorTypography;
using BlazorTypography.Plugins;
using Microsoft.AspNetCore.Components;
using SamplePages.Fonts;
using System.Collections.Generic;
using System.Linq;

namespace SamplePages.Pages
{
    public class ThemeSwitcherBase : ComponentBase
    {
        private readonly FontManager _fm = new FontManager();
        protected List<string> FontNames { get; private set; }
        [Inject] protected ITypography Typography { get; set; }

        public ThemeSwitcherBase()
        {
            FontNames = _fm.Fonts.Select(f => f.Family).ToList();
        }

        //TODO: Remove OnChange and use bind when preview7 (hopefully) fixes binding
        protected string Selected { set; get; } = "Default";
        protected string Fontsize { get; set; } = "16.00";
        protected string Lineheight { get; set; } = "1.50";
        protected string Ratio { get; set; } = "2.00";
        protected string Spacing { get; set; } = "1.00";
        protected string HeaderFont { get; set; } = "-apple-system";
        protected string BodyFont { get; set; } = "georgia";
        protected bool UseCodePlugin { get; set; } = true;
        protected string HeaderWeight { get; set; } = string.Empty;
        protected List<string> HeaderWeights { get; set; } = new List<string>();
        protected string BodyWeight { get; set; } = string.Empty;
        protected List<string> BodyWeights { get; set; } = new List<string>();
        protected string BoldWeight { get; set; } = string.Empty;
        protected List<string> BoldWeights { get; set; } = new List<string>();

        protected override void OnInit()
        {
            DefaultTypographyOptions defaultTheme = new DefaultTypographyOptions
            {
                Plugins = new List<IPlugin> { new CodePlugn() }
            };
            Typography.ApplyTypography(defaultTheme);
        }

        protected void OnChangeSelected(UIChangeEventArgs e)
        {
            Selected = (string)e.Value;
            ITypographyOptions theme = Typography.ThemeForName(Selected);
            Fontsize = Typography.Unitless(theme.BaseFontSize) + ".00";
            Lineheight = theme.BaseLineHeight;
            Ratio = theme.ScaleRatio.ToString();
            Spacing = theme.BlockMarginBottom;
            HeaderFont = theme.HeaderFontFamily[0];
            BodyFont = theme.BodyFontFamily[0];
            HeaderWeights = GetWeightForDropdown(HeaderFont);
            HeaderWeight = theme.HeaderWeight;
            BodyWeights = GetWeightForDropdown(BodyFont);
            BodyWeight = theme.BodyWeight;
            BoldWeights = GetWeightForDropdown(BodyFont);
            BoldWeight = theme.BoldWeight;
        }

        protected void OnChangeFontsize(UIChangeEventArgs e)
        {
            Fontsize = (string)e.Value;
        }

        protected void OnChangeLineheight(UIChangeEventArgs e)
        {
            Lineheight = (string)e.Value;
        }

        protected void OnChangeRatio(UIChangeEventArgs e)
        {
            Ratio = (string)e.Value;
        }

        protected void OnChangeSpacing(UIChangeEventArgs e)
        {
            Spacing = (string)e.Value;
        }

        protected void OnChangeCodePlugin(UIChangeEventArgs e)
        {
            UseCodePlugin = (bool)e.Value;
        }

        protected void OnChangeHeaderFont(UIChangeEventArgs e)
        {
            HeaderFont = (string)e.Value;
            HeaderWeights = GetWeightForDropdown(HeaderFont);
            HeaderWeight = GetBoldStyle(HeaderFont);
        }

        protected void OnChangeBodyFont(UIChangeEventArgs e)
        {
            BodyFont = (string)e.Value;
            BoldWeights = GetWeightForDropdown(BodyFont);
            BoldWeight = GetBoldStyle(BodyFont);
            BodyWeights = GetWeightForDropdown(BodyFont);
            BodyWeight = "400";
        }

        protected void OnChangeHeaderWeight(UIChangeEventArgs e)
        {
            HeaderWeight = (string)e.Value;
        }

        protected void OnChangeBodyWeight(UIChangeEventArgs e)
        {
            BodyWeight = (string)e.Value;
        }

        protected void OnChangeBoldWeight(UIChangeEventArgs e)
        {
            BoldWeight = (string)e.Value;
        }

        protected void OnClick()
        {
            ITypographyOptions theme = Typography.ThemeForName(Selected);
            theme.BaseFontSize = Fontsize + "px";
            theme.BaseLineHeight = Lineheight;
            theme.ScaleRatio = double.Parse(Ratio);
            theme.BlockMarginBottom = Spacing;
            if (UseCodePlugin)
            {
                theme.Plugins = new List<IPlugin> { new CodePlugn() };
            }
            if (theme.HeaderFontFamily[0] != HeaderFont)
            {
                Font headerFont = GetFont(HeaderFont);
                if (headerFont != null)
                {
                    theme.HeaderFontFamily = new List<string> { HeaderFont, headerFont.Category };
                    theme.HeaderWeight = HeaderWeight != "regular" ? HeaderWeight : "400";
                    if (theme.GoogleFonts == null)
                    {
                        theme.GoogleFonts = new List<GoogleFont>();
                    }

                    theme.GoogleFonts.Add(new GoogleFont { Name = HeaderFont, Styles = new List<string> { theme.HeaderWeight } });
                    //TODO: Remove old font here
                }
            }

            if (theme.BodyFontFamily[0] != BodyFont)
            {
                Font bodyFont = GetFont(BodyFont);
                if (bodyFont != null)
                {
                    theme.BodyFontFamily = new List<string> { BodyFont, bodyFont.Category };
                    theme.BodyWeight = BodyWeight != "regular" ? BodyWeight : "400";
                    theme.BoldWeight = BoldWeight != "regular" ? BoldWeight : "400";
                    if (theme.GoogleFonts == null)
                    {
                        theme.GoogleFonts = new List<GoogleFont>();
                    }

                    theme.GoogleFonts.Add(new GoogleFont { Name = BodyFont, Styles = new List<string> { "400", "400i", theme.BoldWeight, theme.BoldWeight + "i" } });
                    //TODO: Remove old font here
                }
            }
            Typography.ApplyTypography(theme);
        }

        private Font GetFont(string font)
        {
            return _fm.Fonts.SingleOrDefault(f => f.Family == font);
        }

        private List<string> GetWeights(string fontName)
        {
            Font Font = GetFont(fontName);
            return Font != null ? Font.Weights : new List<string>();
        }

        private string GetBoldStyle(string font)
        {
            List<string> weights = GetWeights(font);
            List<int> ints = weights.Select(w =>
            {
                int num = int.TryParse(w, out int result) ? result : 0;
                return w == "regular" ? 400 : num;
            }).ToList();
            ints = ints.OrderBy(i => i).ToList();
            return ints.Contains(700) ? "700" : ints.Last().ToString();
        }

        private List<string> GetWeightForDropdown(string font)
        {
            List<string> list = GetWeights(font);
            list = list.Select(w => w == "regular" ? "400" : w).Where(w => int.TryParse(w, out int result)).OrderBy(w => int.Parse(w)).ToList();
            return list;
        }
    }
}
