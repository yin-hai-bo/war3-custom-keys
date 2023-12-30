namespace yhb_war3_custom_keys.model {
    internal class KeyValue : IElement {
        public readonly string Key;
        public readonly string Value;

        public KeyValue(string key, string value) {
            this.Key = key;
            this.Value = value;
        }

        public bool GetKeyValue(out string? key, out string? value) {
            key = this.Key;
            value = this.Value;
            return true;
        }

        public void Serialize(TextWriter writer) {
            writer.WriteLine($"{this.Key}={this.Value}");
        }
    }
}
