namespace yhb_war3_custom_keys.model {
    internal interface IElement {

        /// <summary>
        /// Write self to text writer.
        /// </summary>
        void Serialize(TextWriter writer);

        /// <summary>
        /// Return name when I am a section, otherwise null.
        /// </summary>
        string? SectionName { get; }

        /// <summary>
        /// When I am a key-value pairs (like 'Hotkey=F'), return the key.
        /// If not, return null.
        /// </summary>
        string? Key { get; }

        /// <summary>
        /// When I am a key-value pairs (like 'Hotkey=F'), return the value.
        /// If not, return null.
        /// </summary>
        string? Value { get; }
    }
}
