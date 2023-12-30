namespace yhb_war3_custom_keys.model {
    internal class KeyValue : IItem {
        public readonly string Key;
        public readonly string Value;

        public KeyValue(string key, string value) {
            this.Key = key;
            this.Value = value;
        }

        bool IItem.GetKeyValue(out string? key, out string? value) {
            key = this.Key;
            value = this.Value;
            return true;
        }

        void IItem.Serialize(TextWriter writer) {
            writer.Write($"{this.Key}={this.Value}");
        }
    }
}
