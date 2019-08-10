namespace BlazorTypography
{
    public interface IPlugin
    {
        string Title { get; }
        void Run(Styles styles, ITypographyOptions options, VerticalRhythm vr);
    }
}
