using System.Collections.Generic;

namespace BlazorTypography
{
    //GoogleFont from BlazorStyled could be used instead
    //However, I think it would be nicer to supply our own here
    public class GoogleFont
    {
        public string Name { get; set; }
        public List<string> Styles { get; set; }
    }
}
