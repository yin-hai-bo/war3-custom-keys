namespace yhb_war3_custom_keys.model {

    /// <summary>
    /// The comment element.
    /// No 'Key', no 'Value', and no 'SectionName'.
    /// Just a comment line.
    /// </summary>
    internal class CommentLine : IElement {

        public string Content { get; }

        public CommentLine(string content) {
            this.Content = content;
        }

        public void Serialize(TextWriter writer) {
            writer.WriteLine(this.Content);
        }

        public string? Key => null;
        public string? Value => null;
        public string? SectionName => null;
        IElement IElement.CloneSelf() => CloneSelf();

        public CommentLine CloneSelf() {
            return new CommentLine(this.Content);
        }
    }
}
