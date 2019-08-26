namespace BlazorTypography
{
    public class DefaultTypographyOptions : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Default";
        public override string BaseLineHeight { get; set; } = 1.5f.ToString();
    }
}
