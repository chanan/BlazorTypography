﻿using BlazorTypography;
using BlazorTypography.Plugins;
using Microsoft.AspNetCore.Components;
using SamplePages.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        protected bool UseCodePlugin { get; set; } = false;
        protected string HeaderWeight { get; set; } = string.Empty;
        protected List<String> HeaderWeights { get; set; } = new List<string>();

        private bool isServerSide, hasBeenDone;

        protected override async Task OnInitAsync()
        {
            try
            {
                await Typography.ApplyTypography();
            }
            catch (Exception)
            {
                isServerSide = true;
            }
        }

        protected async override Task OnAfterRenderAsync()
        {
            if (!hasBeenDone & isServerSide)
            {
                await Typography.ApplyTypography();
                hasBeenDone = true;
            }
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
            HeaderWeights = GetWeights(HeaderFont);
            HeaderWeight = theme.HeaderWeight;
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
            HeaderWeights = GetWeights(HeaderFont);
            HeaderWeight = GetBoldStyle(HeaderFont);
        }

        protected void OnChangeBodyFont(UIChangeEventArgs e)
        {
            BodyFont = (string)e.Value;
        }

        protected void OnChangeHeaderWeight(UIChangeEventArgs e)
        {
            HeaderWeight = (string)e.Value;
        }

        protected async void OnClick()
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
            if(theme.HeaderFontFamily[0] != HeaderFont)
            {
                Font headerFont = GetFont(HeaderFont);
                if(headerFont != null)
                {
                    theme.HeaderFontFamily = new List<string> { HeaderFont, headerFont.Category };
                    theme.HeaderWeight = HeaderWeight;
                    if (theme.GoogleFonts == null) theme.GoogleFonts = new List<GoogleFont>();
                    theme.GoogleFonts.Add(new GoogleFont { Name = HeaderFont, Styles = new List<string> { HeaderWeight } });
                    //TODO: Remove old font here
                }
            }
            await Typography.ApplyTypography(theme);
        }

        private Font GetFont(string font)
        {
            return _fm.Fonts.SingleOrDefault(f => f.Family == font);
        }

        private List<string> GetWeights(string fontName)
        {
            var Font = GetFont(fontName);
            return Font != null ? Font.Weights : new List<String>();
        }

        private string GetBoldStyle(string font)
        {
            List<string> weights = GetWeights(font);
            List<int> ints = weights.Select(w => {
                int num = int.TryParse(w, out int result) ? result : 0;
                return w == "regular" ? 400 : num;
            }).ToList();
            ints = ints.OrderBy(i => i).ToList();
            return ints.Contains(700) ? "700" : ints.Last().ToString();
        }
    }
}
