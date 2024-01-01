
using System.Drawing;
using yhb_war3_custom_keys.view;

namespace test {

    [TestFixture]
    public class TestParser {

        [Test]
        public void TestCustomKeyTextParser() {
            CustomKeysParser parser = new();
            Assert.Multiple(() => {
                Assert.That(parser.GetSectionName(" [ Hello ]"), Is.EqualTo("Hello"));
                Assert.That(parser.IsEmptyOrCommentLine("   \t   ".Trim()));
                Assert.That(parser.GetSectionName(" [ Hello ]    "), Is.EqualTo("Hello"));
                Assert.That(parser.GetSectionName(" [ Hello ]   abc"), Is.Null);
            });
        }

        [Test]
        public void TestTipTextParser() {
            var tokens = TipParser.Execute("(|cffffcc00ESC|r) 取消");
            Assert.IsNotNull(tokens);
            Assert.AreEqual(3, tokens.Count);
            Assert.AreEqual("(", tokens[0].Text);
            Assert.IsFalse(tokens[0].HasColor);
            Assert.AreEqual("ESC", tokens[1].Text);
            Assert.IsTrue(tokens[1].HasColor);
            Assert.AreEqual(Color.FromArgb(0xff, 0xff, 0xcc, 0x00), tokens[1].Color);
            Assert.AreEqual(") 取消", tokens[2].Text);
            Assert.IsFalse(tokens[2].HasColor);
        }
    }
}
