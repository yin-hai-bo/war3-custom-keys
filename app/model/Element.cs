namespace yhb_war3_custom_keys.model {
    internal interface IElement {
        void Serialize(TextWriter writer);
        string? SectionName { get; }
        string? Key { get; }
        string? Value { get; }
    }
}
