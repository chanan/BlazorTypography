using System.Collections.Generic;

namespace BlazorTypography.Fonts
{
    internal class Font
    {
        public string Category { get; set; }
        public string Family { get; set; }
        public List<string> Weights { get; set; }
    }
}