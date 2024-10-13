namespace yhb_war3_custom_keys.model {

    internal class KeyValue : IElement {
        public string? SectionName => null;
        public string? Key => _key;
        public string? Value => _value;
        IElement IElement.CloneSelf() => CloneSelf();

        private readonly string _key;
        private readonly string _value;

        public KeyValue(string key, string value) {
            this._key = key;
            this._value = value;
        }

        public void Serialize(TextWriter writer) {
            writer.WriteLine($"{_key}={_value}");
        }

        public override string ToString() {
            return $"{_key}={_value}";
        }

        public override bool Equals(object? obj) {
            if (this == obj) {
                return true;
            }
            if (obj is not KeyValue other) {
                return false;
            }
            return this._key == other._key && this._value == other._value;
        }

        public override int GetHashCode() {
            return HashCode.Combine(this._key, this._value);
        }

        public KeyValue CloneSelf() {
            return new KeyValue(_key, _value);
        }

    }
}
