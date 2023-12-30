
namespace test {

    [TestFixture]
    public class TestParser {

        [Test]
        public void Test1() {
            CustomKeysParser parser = new();
            Assert.Multiple(() => {
                Assert.That(parser.GetSectionName(" [ Hello ]"), Is.EqualTo("Hello"));
                Assert.That(parser.IsEmptyOrCommentLine("   \t   ".Trim()));
                Assert.That(parser.GetSectionName(" [ Hello ]    "), Is.EqualTo("Hello"));
                Assert.That(parser.GetSectionName(" [ Hello ]   abc"), Is.Null);
            });
        }
    }
}
