
namespace test {

    [TestFixture]
    public class TestParser {

        [Test]
        public void Test1() {
            CustomKeysParser parser = new();
            Assert.That(parser.IsEmptyOrCommentLine("   \t   ".Trim()));
            Assert.That("Hello" == parser.GetSectionName(" [ Hello ]    "));
            Assert.IsNull(parser.GetSectionName(" [ Hello ]   abc"));
        }
    }
}
