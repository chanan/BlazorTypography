using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTypography.Themes
{
    class Wikipedia : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Wikipedia";
        public override string BaseFontSize { get; set; } = "14px";
        public override string BaseLineHeight { get; set; } = "1.57";
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "sans-serif" };
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,1)";
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.85)";
        public override string BodyWeight { get; set; } = "normal";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Linux Libertine", "Georgia", "serif" };
        public override string HeaderWeight { get; set; } = "normal";
        public override string BoldWeight { get; set; } = "bold";
        public override Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>> OverrideStyles { get; set; } =
            new Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>>((vr, options) =>
            {
                var ret = new List<KeyValuePair<string, string>>();
                ret.Add(new KeyValuePair<string, string>("h1,h2,h3,h4,h5,h6", $@"
                    border-bottom: 1px solid rgb(170, 170, 170);
                    margin-bottom: calc({vr.Rhythm(1 / 4f)} - 1px);
                    margin-top: {vr.Rhythm(1f)};
                "));
                ret.Add(new KeyValuePair<string, string>("p,ol,ul", @"
                    margin-bottom: 0.5em;
                    margin-top: 0.5em;
                "));
                ret.Add(new KeyValuePair<string, string>("dt", "margin-bottom: 0.1em;"));
                ret.Add(new KeyValuePair<string, string>("dd", @"
                    margin-left: 1.6em;
                    margin-bottom: 0.1em;
                "));
                ret.Add(new KeyValuePair<string, string>("blockquote", $@"
                    margin-top: 1em;
                    margin-bottom: 1em;
                    margin-left: 0;
                    margin-right: 0;
                    padding-left: 40px;
                    padding-right: 40px;
                "));
                ret.Add(new KeyValuePair<string, string>("ol,ul", @"
                    list-style-image: url(data:image/svg+xml,%3C%3Fxml%20version%3D%221.0%22%20encoding%3D%22UTF-8%22%3F%3E%0A%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20width%3D%225%22%20height%3D%2213%22%3E%0A%3Ccircle%20cx%3D%222.5%22%20cy%3D%229.5%22%20r%3D%222.5%22%20fill%3D%22%2300528c%22%2F%3E%0A%3C%2Fsvg%3E%0A);
                    margin-left: 1.6em;
                    margin-top: 0.3em;
                "));
                ret.Add(new KeyValuePair<string, string>("li > ul,li > ol", @"
                    margin-top: 0;
                    margin-left: 1.6em;
                "));
                ret.Add(new KeyValuePair<string, string>("a", @"
                    color: rgb(6, 69, 173);
                    text-decoration: none;
                "));
                ret.Add(new KeyValuePair<string, string>("a:hover", @"
                    text-decoration: underline;
                "));
                ret.Add(new KeyValuePair<string, string>("a:visited", @"
                    color: rgb(11, 0, 128);
                "));
                ret.Add(new KeyValuePair<string, string>("dl", @"
                    margin-top: 0.2em;
                    margin-bottom: 0.5em;
                "));
                return ret;
            });
    }
}
