namespace test {

    [TestFixture]
    public class TextLineReaderTests {
        [Test]
        public void ReadLine_WhenTextProvided_ReturnsCorrectLines() {
            string text = "Line 1 \n Line 2\n Line 3 ";
            TextLineReader reader = new TextLineReader(text);

            Assert.AreEqual(0, reader.NextLine);
            var line1 = reader.ReadLine();
            Assert.AreEqual(1, reader.NextLine);
            var line2 = reader.ReadLine();
            Assert.AreEqual(2, reader.NextLine);
            var line3 = reader.ReadLine();
            Assert.AreEqual(3, reader.NextLine);

            Assert.AreEqual("Line 1", line1);
            Assert.AreEqual("Line 2", line2);
            Assert.AreEqual("Line 3", line3);
        }

        [Test]
        public void MoveBackLine_AfterReadLine_ReturnsCorrectLine() {
            string text = "Line 1\nLine 2";
            TextLineReader reader = new TextLineReader(text);

            var line1 = reader.ReadLine();
            Assert.AreEqual(1, reader.NextLine);
            Assert.AreEqual("Line 1", line1);

            reader.MoveBackLine(line1);
            Assert.AreEqual(0, reader.NextLine);

            string lineAfterMoveBack = reader.ReadLine();
            Assert.AreEqual("Line 1", lineAfterMoveBack);
        }
    }
}