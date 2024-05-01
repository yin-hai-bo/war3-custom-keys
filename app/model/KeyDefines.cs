using yhb_war3_custom_keys.res;

namespace yhb_war3_custom_keys.model {

    /// <summary>
    /// The hot key defines
    /// </summary>
    public class KeyDefines {

        private readonly List<IElement> _elements = new();

        private KeyDefines() { }

        internal static KeyDefines CreateFromFile(string filename) {
            using TextLineReader reader = new(new StreamReader(filename));
            return CreateKeyDefines(reader);
        }

        internal static KeyDefines CreateFromString(string str) {
            using TextLineReader reader = new(str);
            return CreateKeyDefines(reader);
        }

        private static KeyDefines CreateKeyDefines(TextLineReader reader) {
            KeyDefines keyDefines = new();
            keyDefines.LoadFromReader(reader);
            return keyDefines;
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
                Section keyDef = new(sectionName);
                keyDef.LoadFromReader(reader, parser);
                _elements.Add(keyDef);
            }
        }

        public void Serialize(TextWriter writer) {
            foreach (var e in _elements) {
                e.Serialize(writer);
            }
        }

        public Section? GetSection(string sectionName) {
            foreach (var e in _elements) {
                if (e.SectionName == sectionName) {
                    return e as Section;
                }
            }
            return null;
        }
    }
}
