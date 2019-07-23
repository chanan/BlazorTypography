using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        public void ScaleH2()
        {
            VerticalRhythm vr = new VerticalRhythm(new VerticalRhythmOptions { BaseFontSize = "16px", BaseLineHeight = "1.5" });
            BaseLine baseLine = vr.Scale(1);
            Assert.AreEqual("2rem", baseLine.FontSize);
            Assert.AreEqual("2.25rem", baseLine.LineHeight);
        }
    }
}
