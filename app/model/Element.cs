namespace yhb_war3_custom_keys.model {
    internal interface IElement {
        void Serialize(TextWriter writer);
        bool GetKeyValue(out string? key, out string? value);
    }
}
