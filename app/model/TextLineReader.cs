namespace yhb_war3_custom_keys.model {

    public class TextLineReader : IDisposable {

        private readonly TextReader _reader;
        private readonly LinkedList<string> _lines = new();

        public int NextLine { get; private set; }

        public TextLineReader(string text) {
            _reader = new StringReader(text);
        }

        public string? ReadLine(bool trim = true) {
            ++NextLine;
            var node = _lines.First;
            if (node != null) { 
                string result = node.Value;
                _lines.RemoveFirst();
                return result;
            }

            string? line = _reader.ReadLine();
            if (line != null && trim) {
                line = line.Trim();
            }
            return line;
        }

        public void Dispose() {
            this._reader.Dispose();
        }

        public void MoveBackLine(string line) {
            _lines.AddLast(line);
            --NextLine;
        }
    }
}
