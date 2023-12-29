namespace yhb_war3_custom_keys.model {
    internal class KeyDefines {

        internal static KeyDefines? CreateFromString(string str) {
            using (TextLineReader reader = new(str)) {
                try {
                    KeyDefines keyDefines = new KeyDefines();
                    keyDefines.LoadFromReader(reader);
                    return keyDefines;
                } catch (IOException) {
                    return null;
                }

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
                    continue;
                }
                string? sectionName = parser.GetSectionName(line);
                if (sectionName == null) {
                    throw new CustomKeysParser.Exception(reader.NextLine, "Expect a section name.");
                }
                KeyDef keyDef = new(sectionName);
                keyDef.LoadFromReader(reader, parser);
            }
        }
    }
}
