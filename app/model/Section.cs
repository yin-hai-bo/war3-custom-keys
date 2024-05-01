﻿using System.Text.RegularExpressions;
using yhb_war3_custom_keys.res;

namespace yhb_war3_custom_keys.model {

    /// <summary>
    /// A section like :<br /><br />
    ///
    /// [Ahrl]<br />
    /// Tip=|cffffcc00G|rather<br />
    /// Untip=R|cffffcc00e|rturn Resources<br />
    /// Hotkey=G<br />
    /// Unhotkey=E<br />
    ///
    /// </summary>

    public class Section : IElement {

        private static readonly Regex REGEX = new(@"(\w+)\s*=(.*)", RegexOptions.Compiled | RegexOptions.Singleline);

        internal readonly string Name;

        private readonly List<IElement> _items = [];

        internal Section(string name) {
            this.Name = name;
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

        public void Serialize(TextWriter writer) {
            writer.WriteLine($"[{Name}]");
            foreach (var item in _items) {
                item.Serialize(writer);
            }
        }

        public string? Key => null;
        public string? Value => null;
        public string? SectionName => this.Name;

        public string? Find(string key) {
            foreach (var item in _items) {
                if (item.Key == key) {
                    return item.Value;
                }
            }
            return null;
        }
    }
}
