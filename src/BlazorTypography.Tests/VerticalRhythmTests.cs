using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace BlazorTypography.Tests
{
    [TestClass]
    public class VerticalRhythmTests
    {
        [TestMethod]
        public void TestRhythm16()
        {
            VerticalRhythm vr = new VerticalRhythm(new VerticalRhythmOptions { BaseFontSize = "16px", BaseLineHeight = "1.5" });
            Assert.AreEqual("1.5rem", vr.Rhythm(1));
        }

        [TestMethod]
        public void ModularScale1()
        {
            VerticalRhythm vr = new VerticalRhythm(new VerticalRhythmOptions { BaseFontSize = "16px", BaseLineHeight = "1.5" });
            Assert.AreEqual(1.618, vr.ModularScale(1));
        }

        [TestMethod]
        public void ModularScale1MinorSecond()
        {
            VerticalRhythm vr = new VerticalRhythm(new VerticalRhythmOptions { BaseFontSize = "16px", BaseLineHeight = "1.5" });
            Assert.AreEqual(1.067, vr.ModularScale(1, "minor second"));
        }

        [TestMethod]
        public void ScaleH1()
        {
            VerticalRhythm vr = new VerticalRhythm(new VerticalRhythmOptions { BaseFontSize = "16px", BaseLineHeight = "1.5" });
            BaseLine baseLine = vr.Scale(1);
            Assert.AreEqual("2rem", baseLine.FontSize);
            Assert.AreEqual("2.25rem", baseLine.LineHeight);
        }

        [TestMethod]
        public void ScaleH2()
        {
            VerticalRhythm vr = new VerticalRhythm(new VerticalRhythmOptions { BaseFontSize = "16px", BaseLineHeight = "1.5" });
            BaseLine baseLine = vr.Scale(2);
            Assert.AreEqual("4rem", baseLine.FontSize);
            Assert.AreEqual("4.5rem", baseLine.LineHeight);
        }

        [TestMethod]
        public void LocaleOtherThanEnglish()
        {
            CultureInfo cultureInfo = new CultureInfo("fr-LU");
            CultureInfo orig = CultureInfo.CurrentCulture;
            CultureInfo.CurrentCulture = cultureInfo;

            VerticalRhythm vr = new VerticalRhythm(new VerticalRhythmOptions { BaseFontSize = "18px", BaseLineHeight = 1.78f.ToString() });
            BaseLine baseLine = vr.EstablishBaseline();
            Assert.AreEqual("112.5%", baseLine.FontSize);

            vr = new VerticalRhythm(new VerticalRhythmOptions { BaseFontSize = "16px", BaseLineHeight = 1.5f.ToString() });
            baseLine = vr.Scale(1);
            Assert.AreEqual("2.25rem", baseLine.LineHeight);

            CultureInfo.CurrentCulture = orig;
        }
    }
}
