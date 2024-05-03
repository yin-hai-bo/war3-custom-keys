namespace yhb_war3_custom_keys.model {

    internal class KeyValue : IElement {
        public string? SectionName => null;
        public string? Key { get; }
        public string? Value { get; }

        public KeyValue(string key, string value) {
            this.Key = key;
            this.Value = value;
        }

        public void Serialize(TextWriter writer) {
            writer.WriteLine($"{this.Key}={this.Value}");
        }

        public override string ToString() {
            return $"{Key}={Value}";
        }

    }
}
