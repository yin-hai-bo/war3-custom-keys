using yhb_war3_custom_keys.view;
using static yhb_war3_custom_keys.view.FormEdit;

namespace test {
    [TestFixture]
    public class TestHotkeysChecker {

        [Test]
        public void TextNormal() {
            for (int i = 0; i < 256; ++i) {
                string s = char.ConvertFromUtf32(i);
                bool expected = (i >= 'A' && i <= 'Z')
                            ||  (i >= 'a' && i <= 'z')
                            ||  (i >= '0' && i <= '9');
                Assert.AreEqual(expected, HotkeysChecker.Execute(s), $"The text is '{s}'.");
            }
            for (int i = 'A'; i <= 'Z'; ++i) {
                Assert.IsTrue(HotkeysChecker.Execute(i.ToString()));
            }
            Assert.IsTrue(HotkeysChecker.Execute("a,b,c"));
            Assert.IsTrue(HotkeysChecker.Execute("D,E,F"));
            Assert.IsTrue(HotkeysChecker.Execute("27"));
            Assert.IsTrue(HotkeysChecker.Execute("33,44"));
            Assert.IsTrue(HotkeysChecker.Execute("5,6"));
            Assert.IsTrue(HotkeysChecker.Execute("127"));
        }

        [Test]
        public void TestError() {
            Assert.IsFalse(HotkeysChecker.Execute("²âÊÔ"));
            Assert.IsFalse(HotkeysChecker.Execute("-1"));
            Assert.IsFalse(HotkeysChecker.Execute("F,"));
            Assert.IsFalse(HotkeysChecker.Execute("@"));
            Assert.IsFalse(HotkeysChecker.Execute("*"));
            Assert.IsFalse(HotkeysChecker.Execute(",,"));
        }
    }
}
