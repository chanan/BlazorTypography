using BlazorTypography.Internal;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BlazorTypography
{
    public class VerticalRhythm
    {
        private readonly VerticalRhythmOptions _options;
        private readonly Func<string, string, string, string, string> _convert;
        private readonly Func<float?, string, float?, string> _rhythm;
        private readonly string _baseLineHeightInPx;

        private readonly Dictionary<string, double> ratios = new Dictionary<string, double>
        {
            { "minor second", 16 / 15 },
            { "major second", 9 / 8 },
            { "minor third", 6 / 5 },
            { "major third", 4 / 3 },
            { "augmented fourth", Math.Sqrt(2)},
            { "perfect fifth", 3 / 2 },
            { "minor sixth", 8 / 5 },
            { "golden", 1.61803398875 },
            { "phi", 1.61803398875 },
            { "major sixth", 5 / 3 },
            { "minor seventh", 16 / 9 },
            { "major seventh", 15 / 8 },
            { "octave", 2 },
            { "major tenth", 5 / 2 },
            { "major eleventh", 8 / 3 },
            { "major twelfth", 3 },
            { "double octave", 4 }
        };

        public VerticalRhythm() : this(new VerticalRhythmOptions())
        {
        }

        public VerticalRhythm(VerticalRhythmOptions options)
        {
            _options = options;
            _convert = ConvertFactory(_options.BaseFontSize);
            _rhythm = RhythmFactory();

            if (!string.IsNullOrWhiteSpace(Util.Unit(_options.BaseLineHeight)))
            {
                float fontSizeInPx = Util.UnitLess(_convert(_options.BaseFontSize, "px", null, null));
                _baseLineHeightInPx = _convert(_options.BaseLineHeight, "px", null, null);
            }
            else
            {
                float lineheight = Util.UnitLess(_options.BaseFontSize) * Util.UnitLess(_options.BaseLineHeight);
                _baseLineHeightInPx = $"{lineheight}px";
            }
        }

        public readonly string LARGER_DISPLAY_WIDTH = "1600px";
        public readonly string LARGE_DISPLAY_WIDTH = "1280px";
        public readonly string DEFAULT_WIDTH = "980px";
        public readonly string TABLET_WIDTH = "768px";
        public readonly string MOBILE_WIDTH = "480px";

        public readonly string LARGER_DISPLAY_MEDIA_QUERY = "@media only screen and (max-width:1600px)";
        public readonly string LARGE_DISPLAY_MEDIA_QUERY = "@media only screen and (max-width:1280px)";
        public readonly string DEFAULT_MEDIA_QUERY = "@media only screen and (max-width:980px)";
        public readonly string TABLET_MEDIA_QUERY = "@media only screen and (max-width:768px)";
        public readonly string MOBILE_MEDIA_QUERY = "@media only screen and (max-width:480px)";

        public readonly string MIN_LARGER_DISPLAY_MEDIA_QUERY = "@media (min-width:1600px)";
        public readonly string MIN_LARGE_DISPLAY_MEDIA_QUERY = "@media (min-width:1280px)";
        public readonly string MIN_DEFAULT_MEDIA_QUERY = "@media (min-width:980px)";
        public readonly string MIN_TABLET_MEDIA_QUERY = "@media (min-width:768px)";
        public readonly string MIN_MOBILE_MEDIA_QUERY = "@media (min-width:480px)";

        public BaseLine AdjustFontSizeTo(string toSize)
        {
            return AdjustFontSizeTo(toSize, null, null);
        }

        public BaseLine AdjustFontSizeTo(string toSize, string lines)
        {
            return AdjustFontSizeTo(toSize, lines, null);
        }

        public BaseLine AdjustFontSizeTo(string toSize, string lines, string fromSize)
        {
            if (string.IsNullOrWhiteSpace(lines))
            {
                lines = "auto";
            }

            if (fromSize == null)
            {
                fromSize = _options.BaseFontSize;
            }

            if (Util.Unit(toSize) == "%")
            {
                toSize = Util.UnitLess(_options.BaseFontSize) * (Util.UnitLess(toSize) / 100) + "px";
            }

            fromSize = _convert(fromSize, "px", null, null);
            toSize = _convert(toSize, "px", fromSize, null);

            if (lines == "auto")
            {
                lines = Math.Round(LinesForFontSize(toSize), 2).ToString();
            }

            float linesFloat = Util.UnitLess(lines);

            return new BaseLine
            {
                FontSize = _convert(toSize, _options.RhythmUnit, fromSize, null),
                LineHeight = Rhythm(linesFloat, fromSize, null)
            };
        }

        public string Gray()
        {
            return Gray(0, null, false);
        }

        public string Gray(int lightness)
        {
            return Gray(lightness, null, false);
        }

        public string Gray(int lightness, string hue = null)
        {
            return Gray(lightness, hue, false);
        }

        public string Gray(int lightness, string hue = null, bool darkBackground = false)
        {
            int? hueNum = null;
            if (hue == null)
            {
                hueNum = 0;
            }

            // Convert named hues into numeric lightness value.
            if (hue == "cool")
            {
                hueNum = 237;
            }
            else if (hue == "slate")
            {
                hueNum = 122;
            }
            else if (hue == "warm")
            {
                hueNum = 69;
            }

            if (!hueNum.HasValue)
            {
                if (int.TryParse(hue, out int result))
                {
                    hueNum = result;
                }
                else
                {
                    throw new ArgumentException("hue is not a number");
                }
            }

            if (lightness > 100)
            {
                lightness = 100;
            }
            if (lightness < 0)
            {
                lightness = 0;
            }

            double saturation = 0;
            if (hueNum != 0)
            {
                double a = 19.92978;
                double b = -0.3651759;
                double c = 0.001737214;
                saturation = a + b * lightness + c * Math.Pow(lightness, 2);
            }

            string lightnessStr;
            double opacity;
            if (darkBackground)
            {
                opacity = lightness / 100d;
                lightnessStr = "100%,";
            }
            else
            {
                opacity = (100 - lightness) / 100d;
                lightnessStr = "0%,";
            }

            return "hsla(" + hueNum + "," + saturation + "%," + lightnessStr + opacity + ")";
        }

        public float LinesForFontSize(string fontSize)
        {
            float lines;
            float fontSizeInPx = Util.UnitLess(_convert(fontSize, "px", null, null));
            float lineHeightInPx = Util.UnitLess(_baseLineHeightInPx);
            float minLinePadding = Util.UnitLess(_convert(_options.MinLinePadding, "px", null, null));

            if (_options.RoundToNearestHalfLine)
            {
                lines = (float)(Math.Ceiling(2 * fontSizeInPx / lineHeightInPx) / 2);
            }
            else
            {
                lines = (float)Math.Ceiling(fontSizeInPx / lineHeightInPx);
            }

            // If lines are cramped, include some extra lead.
            if (lines * lineHeightInPx - fontSizeInPx < minLinePadding * 2)
            {
                if (_options.RoundToNearestHalfLine)
                {
                    lines += 0.5f;
                }
                else
                {
                    lines += 1;
                }
            }

            return lines;
        }

        public BaseLine EstablishBaseline()
        {
            return new BaseLine
            {
                FontSize = Util.UnitLess(_options.BaseFontSize) / 16 * 100 + "%",
                LineHeight = _options.BaseLineHeight
            };
        }

        public string Rhythm()
        {
            return _rhythm(null, null, null);
        }

        public string Rhythm(float? lines)
        {
            return _rhythm(lines, null, null);
        }

        public string Rhythm(float? lines, string fontSize)
        {
            return _rhythm(lines, fontSize, null);
        }

        public string Rhythm(float? lines, string fontSize, float? offset)
        {
            return _rhythm(lines, fontSize, offset);
        }

        public BaseLine Scale(float value)
        {
            int baseFont = int.Parse(Util.UnitLess(_options.BaseFontSize).ToString());
            string newFontSize = $"{ModularScale(value, null) * baseFont}px";
            return AdjustFontSizeTo(newFontSize, null, null);
        }

        public BaseLine Scale(float value, string scaleRatio)
        {
            int baseFont = int.Parse(Util.UnitLess(_options.BaseFontSize).ToString());
            string newFontSize = $"{ModularScale(value, scaleRatio) * baseFont}px";
            return AdjustFontSizeTo(newFontSize, null, null);
        }

        private Func<float?, string, float?, string> RhythmFactory()
        {
            return new Func<float?, string, float?, string>((lines, fontSize, offset) =>
            {
                if (!lines.HasValue)
                {
                    lines = 1;
                }

                if (string.IsNullOrWhiteSpace(fontSize))
                {
                    fontSize = _options.BaseFontSize;
                }

                if (!offset.HasValue)
                {
                    offset = 0;
                }

                string length = lines * Util.UnitLess(_baseLineHeightInPx) - offset + "px";
                string rhythmLength = _convert(length, _options.RhythmUnit, fontSize, null);
                if (Util.Unit(rhythmLength) == "px")
                {
                    rhythmLength = Math.Floor(Util.UnitLess(rhythmLength)) + Util.Unit(rhythmLength);
                }

                // Limit to 5 decimals.
                return Math.Round(Util.UnitLess(rhythmLength), 5) + Util.Unit(rhythmLength);
            });
        }

        private Func<string, string, string, string, string> ConvertFactory(string baseFontSize)
        {
            return new Func<string, string, string, string, string>((length, toUnit, fromContext, toContext) =>
            {
                if (fromContext == null)
                {
                    fromContext = baseFontSize;
                }
                if (toContext == null)
                {
                    toContext = fromContext;
                }
                string fromUnit = Util.Unit(length);

                // Optimize for cases where `from` and `to` units are accidentally the same.
                if (fromUnit == toUnit)
                {
                    return length;
                }

                float pxLength = Util.UnitLess(length);
                if (fromUnit != "px")
                {
                    if (fromUnit == "em")
                    {
                        pxLength = Util.UnitLess(length) * Util.UnitLess(fromContext);
                    }
                    else if (fromUnit == "rem")
                    {
                        pxLength = Util.UnitLess(length) * Util.UnitLess(baseFontSize);
                    }
                    else if (fromUnit == "ex")
                    {
                        pxLength = Util.UnitLess(length) * Util.UnitLess(fromContext) * 2;
                    }
                    else
                    {
                        return length;
                    }
                }

                float outputLength = pxLength;
                if (toUnit != "px")
                {
                    if (toUnit == "em")
                    {
                        outputLength = pxLength / Util.UnitLess(toContext);
                    }
                    else if (toUnit == "rem")
                    {
                        outputLength = pxLength / Util.UnitLess(baseFontSize);
                    }
                    else if (toUnit == "ex")
                    {
                        outputLength = pxLength / Util.UnitLess(toContext) / 2;
                    }
                    else
                    {
                        return length;
                    }
                }
                return Math.Round(outputLength, 2) + toUnit;
            });
        }

        private float ModularScale(float value, string ratio = "golden")
        {
            if (ratio == null)
            {
                ratio = "golden";
            }

            double r;
            if (float.TryParse(ratio, out float f))
            {
                r = f;
            }
            else if (ratios.ContainsKey(ratio))
            {
                r = ratios[ratio];
            }
            else
            {
                r = ratios["golden"];
            }
            return (float)Math.Round(Math.Pow(r, value), 2);
        }
    }
}
