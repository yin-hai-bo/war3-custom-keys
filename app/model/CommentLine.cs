namespace yhb_war3_custom_keys.model {
    internal class CommentLine : IElement {

        private readonly string _content;

        public CommentLine(string content) {
            this._content = content;
        }

        public void Serialize(TextWriter writer) {
            writer.WriteLine(this._content);
        }

        public string? Key => null;
        public string? Value => null;
        public string? SectionName => null;
    }
}
