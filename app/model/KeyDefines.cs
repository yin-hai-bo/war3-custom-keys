namespace yhb_war3_custom_keys.model {

    internal class KeyDefines {

        private readonly List<IElement> _elements = new();

        public static KeyDefines DefaultInstance { get; private set; }

        public static void CreateoDefaultInstance() {
            DefaultInstance = CreateFromString(Resources.CustomKeysSample);

            using (StreamWriter writer = new(new FileStream("c:\\temp\\tmp.txt", FileMode.Truncate))) {
                DefaultInstance.Serialize(writer);
            }
        }

        private KeyDefines() { }

        internal static KeyDefines CreateFromString(string str) {
            using (TextLineReader reader = new(str)) {
                KeyDefines keyDefines = new KeyDefines();
                keyDefines.LoadFromReader(reader);
                return keyDefines;
            }
        }

        private void LoadFromReader(TextLineReader reader) {
            CustomKeysParser parser = new();
            while (true) {
                var line = reader.ReadLine(trim: true);
                if (line == null) {
                    break;
                }
                if (parser.IsEmptyOrCommentLine(line)) {
                    _elements.Add(new CommentLine(line));
                    continue;
                }
                string? sectionName = parser.GetSectionName(line);
                if (sectionName == null) {
                    throw new CustomKeysParser.Exception(reader.NextLine, Resources.S_SECTION_DEFINE_EXPECTED);
                }
                KeyDef keyDef = new(sectionName);
                keyDef.LoadFromReader(reader, parser);
                _elements.Add(keyDef);
            }
        }

        public void Serialize(TextWriter writer) {
            foreach (var e in _elements) {
                e.Serialize(writer);
            }
        }
    }
}
