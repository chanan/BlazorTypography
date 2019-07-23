using BlazorStyled;
using Polished;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BlazorTypography.Internal
{
    internal class Typography : ITypography
    {
        private readonly IStyled _styled;
        private readonly IMixins _mixins;
        private readonly Type _pluginType = typeof(IPlugin);
        private readonly Type _themeType = typeof(ITypographyOptions);

        private readonly List<string> _genericFontFamilies = new List<string> {
          "inherit",
          "default",
          "serif",
          "sans-serif",
          "monospace",
          "fantasy",
          "cursive",
          "-apple-system",
        };

        public Typography(IStyled styled, IMixins mixins)
        {
            _styled = styled;
            _mixins = mixins;
        }

        public List<string> Themes => (from type in Assembly.GetAssembly(_themeType).DefinedTypes
                                       where type.ImplementedInterfaces.Contains(_themeType)
                                       && !type.IsAbstract
                                       && type.Name != "VerticalRhythmOptions"
                                       select GetTitle(type)).ToList();

        public Task ApplyTypography()
        {
            return ApplyTypography(new DefaultTypographyOptions());
        }

        public async Task ApplyTypography(ITypographyOptions options)
        {
            await _styled.ClearStyles();
            VerticalRhythm vr = new VerticalRhythm(new VerticalRhythmOptions(options));

            if (options.IncludeNormalize.HasValue && options.IncludeNormalize.Value)
            {
                await _styled.Css(_mixins.Normalize());
            }

            //Not sure if html section is correct see:
            //https://github.com/KyleAMathews/typography.js/blob/master/packages/typography/src/utils/createStyles.js#L55-L61

            string bodyFontFamily = string.Join(",", options.BodyFontFamily.Select(f => WrapFontFamily(f)));
            string headerFontFamily = string.Join(",", options.HeaderFontFamily.Select(f => WrapFontFamily(f)));
            BaseLine baseLine = vr.EstablishBaseline();
            string rhythm1 = vr.Rhythm(1);

            await _styled.Css("html", $@"
                font-size: {baseLine.FontSize};
                font-family: {bodyFontFamily};
                line-height: {baseLine.LineHeight}em;
                box-sizing: border-box;
                overflow-y: scroll;
            ");

            // box-sizing reset.
            await _styled.Css(new List<string>
            {
                "*",
                "*:before",
                "*:after"
            }, @"
                box-sizing: inherit;
            ");

            // Base body styles.
            await _styled.Css("body", $@"
                color: {options.BodyColor};
                font-family: {bodyFontFamily};
                font-weight: {options.BodyWeight};
                word-wrap: break-word;
                font-kerning: normal;
                -moz-font-feature-settings: ""kern"", ""liga"", ""clig"", ""calt"";
                -ms-font-feature-settings: ""kern"", ""liga"", ""clig"", ""calt"";
                -webkit-font-feature-settings: ""kern"", ""liga"", ""clig"", ""calt"";
                font-feature-settings: ""kern"", ""liga"", ""clig"", ""calt"";
            ");

            // Make images responsive.
            await _styled.Css("img", "max-width: 100%;");

            // All block elements get one rhythm of bottom margin by default
            // or whatever is passed in as option.
            string blockMarginBottom = "";
            if (float.TryParse(options.BlockMarginBottom, out float result))
            {
                blockMarginBottom = vr.Rhythm(result);
            }
            else if (!string.IsNullOrWhiteSpace(options.BlockMarginBottom))
            {
                blockMarginBottom = options.BlockMarginBottom;
            }
            else
            {
                blockMarginBottom = rhythm1;
            }

            // Reset margin/padding to 0.
            await _styled.Css(new List<string>
            {
                "h1",
                "h2",
                "h3",
                "h4",
                "h5",
                "h6",
                "hgroup",
                "ul",
                "ol",
                "dl",
                "dd",
                "p",
                "figure",
                "pre",
                "table",
                "fieldset",
                "blockquote",
                "form",
                "noscript",
                "iframe",
                "img",
                "hr",
                "address"
            }, $@"
                margin-left: 0;
                margin-right: 0;
                margin-top: 0;
                padding-bottom: 0;
                padding-left: 0;
                padding-right: 0;
                padding-top: 0;
                margin-bottom: {blockMarginBottom};
            ");

            // Basic blockquote styles
            await _styled.Css("blockquote", $@"
                margin-right: {rhythm1};
                margin-bottom: {blockMarginBottom};
                margin-left: {rhythm1};
            ");

            // b, strong.
            await _styled.Css(new List<string> {
                "b",
                "strong",
                "dt",
                "th"
            }, $@"
                font-weight: {options.BoldWeight};
            ");

            // hr.
            await _styled.Css("hr", $@"
                background: {vr.Gray(80)};
                border: none;
                height: 1px;
                margin-bottom: calc({blockMarginBottom} - 1px);
            ");

            // ol, ul.
            await _styled.Css(new List<string>
            {
                "ol",
                "ul"
            }, $@"
                list-style-position: outside;
                list-style-image: none;
                margin-left: {rhythm1};
            ");

            // li.
            await _styled.Css("li", $@"
                margin-bottom: calc({blockMarginBottom} / 2);
            ");

            // Remove default padding on list items.
            await _styled.Css(new List<string>
            {
                "ol li",
                "ul li"
            }, @"
                 padding-left: 0;
            ");

            // children ol, ul.
            await _styled.Css(new List<string>
            {
                "li > ol",
                "li > ul"
            }, $@"
                margin-left: {rhythm1};
                margin-bottom: calc({blockMarginBottom} / 2);
                margin-top: calc({blockMarginBottom} / 2);
            ");

            // Remove margin-bottom on the last-child of a few block elements
            // The worst offender of this seems to be markdown => html compilers
            // as they put paragraphs within LIs amoung other oddities.
            await _styled.Css(new List<string> {
                "blockquote *:last-child",
                "li *:last-child",
                "p *:last-child"
            }, @"
                margin-bottom: 0;
            ");

            // Ensure li > p is 1/2 margin — this is another markdown => compiler oddity.
            await _styled.Css("li > p", $@"
                margin-bottom: calc({blockMarginBottom} / 2);
            ");

            // Make generally smaller elements, smaller.
            BaseLine smaller = vr.AdjustFontSizeTo("85%");
            await _styled.Css(new List<string>{
                "code",
                "kbd",
                "pre",
                "samp"
            }, $@"
                {smaller}
            ");

            // Abbr, Acronym.
            await _styled.Css(new List<string> {
                "abbr",
                "acronym"
            }, $@"
                border-bottom: 1px dotted {vr.Gray(50)};
                cursor: help;
            ");

            await _styled.Css("abbr[title]", $@"
                border-bottom: 1px dotted {vr.Gray(50)};
                cursor: help;
                text-decoration: none;
            ");

            // Table styles.
            BaseLine tableBaseLine = vr.AdjustFontSizeTo(options.BaseFontSize, null, null);
            await _styled.Css("table", $@"
                {tableBaseLine}
                border-collapse: collapse;
                width: 100%;
            ");

            await _styled.Css("thead", @"
                text-align: left;
            ");

            string rhythmTwoThirds = vr.Rhythm(2 / 3f);
            string rhythmHalf = vr.Rhythm(1 / 2f);
            await _styled.Css(new List<string>
            {
                "td",
                "th"
            }, $@"
                text-align: left;
                border-bottom: 1px solid {vr.Gray(88)};
                font-feature-settings: ""tnum"";
                - moz-font-feature-settings: ""tnum"";
                -ms-font-feature-settings: ""tnum"";
                -webkit-font-feature-settings: ""tnum"";
                padding-left: {rhythmTwoThirds};
                padding-right:{rhythmTwoThirds};
                padding-top: {rhythmHalf};
                padding-bottom: calc({rhythmHalf} - 1px);,
            ");

            await _styled.Css("th:first-child,td:first-child", @"
                padding-left: 0;
            ");

            await _styled.Css("", @"
                padding-right: 0;
            ");

            // Create styles for headers.
            await _styled.Css(new List<string>
            {
                "h1",
                "h2",
                "h3",
                "h4",
                "h5",
                "h6"
            }, $@"
                color: {options.HeaderColor};
                font-family: {headerFontFamily};
                font-weight: {options.HeaderWeight};
                text-rendering: optimizeLegibility;
            ");

            // Set header sizes.
            BaseLine h1 = vr.Scale(5 / 5f);
            BaseLine h2 = vr.Scale(3 / 5f);
            BaseLine h3 = vr.Scale(2 / 5f);
            BaseLine h4 = vr.Scale(0 / 5f);
            BaseLine h5 = vr.Scale(-1 / 5f);
            BaseLine h6 = vr.Scale(-1.5f / 5f);

            await _styled.Css("h1", $@"
                {h1}
            ");

            await _styled.Css("h2", $@"
                {h2}
            ");

            await _styled.Css("h3", $@"
                {h3}
            ");

            await _styled.Css("h4", $@"
                {h4}
            ");

            await _styled.Css("h5", $@"
                {h5}
            ");

            await _styled.Css("h6", $@"
                {h6}
            ");

            // TODO add support for Breakpoints here. (Missing in Typography.js)

            // Call plugins if any.
            if (options.Plugins != null)
            {
                foreach (IPlugin plugin in options.Plugins)
                {
                    IList<KeyValuePair<string, string>> list = plugin.Run(options, vr);
                    if (list != null)
                    {
                        await AddList(list);
                    }
                }
            }

            // Call OverrideStyles function on options (if set).
            if (options.OverrideStyles != null)
            {
                IList<KeyValuePair<string, string>> list = options.OverrideStyles(vr, options);
                if (list != null)
                {
                    await AddList(list);
                }
            }

            // Call overrideThemeStyles function on options (if set).
            if (options.OverrideThemeStyles != null)
            {
                IList<KeyValuePair<string, string>> list = options.OverrideThemeStyles(vr, options);
                if (list != null)
                {
                    await AddList(list);
                }
            }

            // Set google fonts
            if (options.GoogleFonts != null)
            {
                List<BlazorStyled.GoogleFont> list = options.GoogleFonts.Select(font => new BlazorStyled.GoogleFont { Name = font.Name, Styles = font.Styles }).ToList();
                await _styled.AddGoogleFonts(list);
            }
        }

        private async Task AddList(IList<KeyValuePair<string, string>> list)
        {
            foreach ((KeyValuePair<string, string> item, string key) in from KeyValuePair<string, string> item in list
                                                                        let keys = item.Key.Split(',')
                                                                        from string key in keys
                                                                        where !string.IsNullOrWhiteSpace(key.Trim())
                                                                        select (item, key))
            {
                await _styled.Css(key.Trim(), item.Value.Trim());
            }
        }

        private string WrapFontFamily(string fontFamily)
        {
            return _genericFontFamilies.Contains(fontFamily) ? fontFamily : $@"""{fontFamily}""";
        }

        private string GetTitle(TypeInfo type)
        {
            PropertyInfo prop = type.GetProperty("Title");
            return (string)prop.GetGetMethod().Invoke(Activator.CreateInstance(type, null), null);
        }

        public ITypographyOptions ThemeForName(string name)
        {
            ITypographyOptions theme = null;
            List<TypeInfo> themes = (from type in Assembly.GetAssembly(_themeType).DefinedTypes
                                     where type.ImplementedInterfaces.Contains(_themeType)
                                     && !type.IsAbstract
                                     && type.Name != "VerticalRhythmOptions"
                                     select type).ToList();

            foreach (TypeInfo type in themes)
            {
                if (GetTitle(type).ToLower() == name.ToLower())
                {
                    theme = (ITypographyOptions)Activator.CreateInstance(type, null);
                    break;
                }
            }
            return theme;
        }

        public float Unitless(string value)
        {
            return Util.UnitLess(value);
        }
    }
}