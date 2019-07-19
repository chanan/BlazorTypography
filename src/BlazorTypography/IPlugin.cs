using System.Collections.Generic;

namespace BlazorTypography
{
    public interface IPlugin
    {
        IList<KeyValuePair<string, string>> Run(ITypographyOptions options, VerticalRhythm vr);
    }
}
