using System.Text.RegularExpressions;

namespace yhb_war3_custom_keys.model {
    internal class KeyDef {

        private static readonly Regex REGEX = new(@"(\w+)\s*=(.*)", RegexOptions.Compiled | RegexOptions.Singleline);

        internal readonly string Key;

        private readonly List<IItem> _items = new();

        internal KeyDef(string key) {
            this.Key = key;
        }

        internal void LoadFromReader(TextLineReader reader, CustomKeysParser parser) {
            while (true) {
                string? line = reader.ReadLine(trim: true);
                if (line == null) {
                    break;
                }
                if (parser.IsEmptyOrCommentLine(line)) {
                    _items.Add(new CommentLine(line));
                    continue;
                }
                var match = REGEX.Match(line);
                if (match.Success) {
                    var key = match.Groups[1].Value;
                    var value = match.Groups[2].Value.Trim();
                    _items.Add(new KeyValue(key, value));
                } else if (parser.GetSectionName(line) != null) {
                    reader.MoveBackLine(line);
                    break;
                } else {
                    throw new CustomKeysParser.Exception(reader.NextLine, Resources.S_INVALID_LINE);
                }
            }
        }
    }
}
