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
                string? line = reader.ReadLine(trim: true);
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

                // If last line is a comment line, use it to this section description.
                string? lastComment = FindLastComment(_elements);
                Section keyDef = new(sectionName, lastComment);
                keyDef.LoadFromReader(reader, parser);
                _elements.Add(keyDef);
            }
        }

        private static string? FindLastComment(IReadOnlyList<IElement> elements) {
            if (elements.Count == 0) { return null; }
            IElement lastElement = elements[^1];

            CommentLine? comment = lastElement as CommentLine;
            if (comment != null) {
                return GetCommentContentFromCommentLine(comment);
            }

            Section? section = lastElement as Section;
            if (section == null || section.Count == 0) { return null; }
            return GetCommentContentFromCommentLine(section[^1] as CommentLine);
        }

        private static string? GetCommentContentFromCommentLine(CommentLine? commentLine) {
            if (commentLine == null || commentLine.Content == null) { return null; }
            return commentLine.Content.Length > 2 ? commentLine.Content.Substring(2) : null;
        }

        public void Serialize(TextWriter writer) {
            foreach (var e in _elements) {
                e.Serialize(writer);
            }
        }

        internal Section? GetSection(string sectionName) {
            foreach (var e in _elements) {
                if (e.SectionName == sectionName) {
                    return e as Section;
                }
            }
            return null;
        }
    }
}
