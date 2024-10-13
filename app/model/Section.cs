using System.Collections;
using System.Text.RegularExpressions;
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

    internal partial class Section : IElement, IReadOnlyList<IElement> {

        internal readonly string Name;
        internal readonly string? Description;

        private readonly List<IElement> _items = [];

        internal Section(string name, string? description) {
            this.Name = name;
            this.Description = description;
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

                var match = GeneratedRegex().Match(line);
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

        #region IElement
        string? IElement.Key => null;
        string? IElement.Value => null;
        string IElement.SectionName => this.Name;
        IElement IElement.CloneSelf() => this.CloneSelf();
        #endregion

        public Section CloneSelf() {
            Section result = new(this.Name, this.Description);
            foreach (IElement e in this._items) {
                result._items.Add(e.CloneSelf());
            }
            return result;
        }

        public string? Find(string key) {
            foreach (var item in _items) {
                if (item.Key == key) {
                    return item.Value;
                }
            }
            return null;
        }

        #region IReadOnlyList

        public int Count => _items.Count;

        public IElement this[int index] => _items[index];

        public IEnumerator<IElement> GetEnumerator() {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
        }

        #endregion

        public override string ToString() {
            return $"([{Name}] {Description} Count={Count})";
        }

        [GeneratedRegex(@"(\w+)\s*=(.*)", RegexOptions.Compiled | RegexOptions.Singleline)]
        private static partial Regex GeneratedRegex();
    }
}
