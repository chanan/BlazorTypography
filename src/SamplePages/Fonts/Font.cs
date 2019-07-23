using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace SamplePages.Fonts
{
    public class Font
    {
        public string Category { get; set; }
        public string Family { get; set; }
        public List<string> Weights { get; set; }
    }
}