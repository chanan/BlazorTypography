namespace BlazorTypography
{
    public interface IPlugin
    {
        void Run(Styles styles, ITypographyOptions options, VerticalRhythm vr);
    }
}
