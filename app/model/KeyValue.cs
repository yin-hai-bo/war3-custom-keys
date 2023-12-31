namespace yhb_war3_custom_keys.model {
    internal class KeyValue : IElement {
        public readonly string Key;
        public readonly string Value;

        public KeyValue(string key, string value) {
            this.Key = key;
            this.Value = value;
        }

        public void Serialize(TextWriter writer) {
            writer.WriteLine($"{this.Key}={this.Value}");
        }

        string? IElement.Key => this.Key;
        string? IElement.Value => this.Value;
        public string? SectionName => null;
    }
}
