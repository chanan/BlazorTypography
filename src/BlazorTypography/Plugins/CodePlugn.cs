using System.Collections.Generic;

namespace BlazorTypography.Plugins
{
    public class CodePlugn : IPlugin
    {
        public IList<KeyValuePair<string, string>> Run(ITypographyOptions options, VerticalRhythm vr)
        {

            string rhythm1 = vr.Rhythm(1);
            string blockMarginBottom;
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

            IList<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("tt,code", $@"
                    background-color: {vr.Gray(96)};
                    border-radius: 3px;
                    font-family: ""SFMono - Regular"", Consolas, ""Roboto Mono"" ,""Droid Sans Mono"", ""Liberation Mono"", Menlo, Courier, monospace;
                    padding: 0;
                    padding-top: 0.2em;
                    padding-bottom: 0.2em;
                "),
                new KeyValuePair<string, string>("pre", $@"
                    background: {vr.Gray(96)};
                    border-radius: 3px;
                    line-height: 1.42;
                    overflow: auto;
                    word-wrap: normal;
                    padding: {blockMarginBottom};
                "),
                new KeyValuePair<string, string>("pre code", @"
                    background: none;
                    line-height: 1.42;
                "),
                new KeyValuePair<string, string>("code:before,code:after,tt:before,tt:after", @"
                    letter-spacing: -0.2em;
                    content: "" "";
                "),
                new KeyValuePair<string, string>("pre code:before,pre code:after,pre tt:before,pre tt:after", @"
                    content: none;
                ")
            };
            return list;
        }
    }
}
