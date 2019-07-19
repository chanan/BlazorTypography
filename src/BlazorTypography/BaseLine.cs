namespace BlazorTypography
{
    public class BaseLine
    {
        public string FontSize { get; set; }
        public string LineHeight { get; set; }

        public override string ToString()
        {
            return $@"
                font-size: {FontSize};
                line-height: {LineHeight};
            ";
        }
    }
}
