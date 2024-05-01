using System.ComponentModel;
using System.Text.RegularExpressions;
using yhb_war3_custom_keys.model;

namespace yhb_war3_custom_keys.view {

    public class KeyDefinesToListView : IDisposable {
        private static readonly Pen PEN_GRID_LINE = new Pen(Color.FromArgb(255, 80, 80, 80), 1);

        private static readonly Brush BRUSH_HEAD_BACKGROUND = new SolidBrush(Color.FromArgb(255, 40, 40, 50));
        private static readonly Brush BRUSH_HEAD_FOREGROUND = new SolidBrush(Color.FromArgb(255, 128, 192, 192));

        private static readonly Brush BRUSH_ROW_BACKGROUND = Brushes.Black;
        private static readonly Brush BRUSH_ROW_FOREGROUND = Brushes.White;
        private static readonly Brush BRUSH_FIRST_COLUMN_FOREGROUND = BRUSH_HEAD_FOREGROUND;

        private enum SubItemTag {
            [Description("Hotkey")]
            Hotkey,
            [Description("Unhotkey")]
            Unhotkey,
            [Description("Researchhotkey")]
            Researchhotkey,
            [Description("Tip")]
            Tip,
            [Description("Revivetip")]
            Revivetip,
            [Description("Awakentip")]
            Awakentip,
        }

        public string CategoryName { get; }
        public string Group { get; }

        private readonly KeyDefines _keyDefines;
        private readonly IReadOnlyCollection<KeyDefinesCategory.Entry> _entries;
        private readonly ListView _listView;

        private readonly Action<KeyDefinesToListView, ListViewItem, Section> _doubleClickCallback;

        private bool _disposed;

        /// <summary>
        /// Construction.
        /// </summary>
        /// <param name="categoryName">The category name, like "Human", "Orc", "Common", ...</param>
        /// <param name="group">Group name, like "Heroes", "Units", ...</param>
        /// <param name="parent">Parent UI component</param>
        /// <param name="keyDefines"><see cref="KeyDefines"/></param>
        /// <param name="entries">The list of <see cref="KeyDefinesCategory.Entry"/></param>
        /// <param name="doubleClickCallback">Callback when user double click list view.</param>
        internal KeyDefinesToListView(
            string categoryName,
            string group,
            Control parent,
            KeyDefines keyDefines,
            IReadOnlyCollection<KeyDefinesCategory.Entry> entries,
            Action<KeyDefinesToListView, ListViewItem, Section> doubleClickCallback
        ) {
            this.CategoryName = categoryName;
            this.Group = group;

            _keyDefines = keyDefines;
            _entries = entries;
            _listView = new() {
                Parent = parent,
                Dock = DockStyle.Fill,
                View = View.Details,
                HeaderStyle = ColumnHeaderStyle.Nonclickable,
                OwnerDraw = true,
                BackColor = Color.Black,
                ForeColor = Color.White,
                MultiSelect = false,
                FullRowSelect = true,
                HideSelection = false,
            };
            _listView.DrawColumnHeader += OnListViewDrawColumnHeader;
            _listView.DrawItem += OnListViewDrawItem;
            _listView.DrawSubItem += OnListViewDrawSubItem;
            _listView.DoubleClick += OnListViewDoubleClick;

            _listView.BeginUpdate();
            AddEntriesToListView();
            _listView.EndUpdate();

            _doubleClickCallback = doubleClickCallback;
        }

        private void AddEntriesToListView() {
            var columns = _listView.Columns;
            columns.Add(string.Empty);
            columns.Add("Hotkey").TextAlign = HorizontalAlignment.Center;
            columns.Add("Unhotkey").TextAlign = HorizontalAlignment.Center;
            columns.Add("Researchhotkey").TextAlign = HorizontalAlignment.Center;
            columns.Add("Tip");
            columns.Add("Revivetip");
            columns.Add("Awakentip");

            foreach (var entry in _entries) {
                Section? section = _keyDefines.GetSection(entry.SectionName);
                if (section != null) {
                    var row = _listView.Items.Add(entry.Description);
                    AddSubItem(row, section.Find("Hotkey"), SubItemTag.Hotkey);
                    AddSubItem(row, section.Find("Unhotkey"), SubItemTag.Unhotkey);
                    AddSubItem(row, section.Find("Researchhotkey"), SubItemTag.Researchhotkey);
                    AddSubItem(row, section.Find("Tip"), SubItemTag.Tip);
                    AddSubItem(row, section.Find("Revivetip"), SubItemTag.Revivetip);
                    AddSubItem(row, section.Find("Awakentip"), SubItemTag.Awakentip);
                    row.Tag = section;
                }
            }
            foreach (ColumnHeader col in columns) {
                col.Width = -2;
            }
        }

        public void Dispose() {
            if (!_disposed) {
                _disposed = true;
                _listView.Parent.Controls.Remove(_listView);
                _listView.Dispose();
            }
        }

        private void OnListViewDoubleClick(object? sender, EventArgs e) {
            if (_listView.SelectedItems != null && _listView.SelectedItems.Count > 0) {
                var selected = _listView.SelectedItems[0];
                _doubleClickCallback?.Invoke(this, selected, (Section)selected.Tag);
            }
        }

        private static void OnListViewDrawItem(object? sender, DrawListViewItemEventArgs e) { }

        private static void AddSubItem(ListViewItem row, string? text, SubItemTag tag) {
            var subItem = row.SubItems.Add(text);
            subItem.Tag = tag;
            switch (tag) {
            case SubItemTag.Hotkey:
            case SubItemTag.Unhotkey:
            case SubItemTag.Researchhotkey:
                subItem.ForeColor = Color.FromArgb(0xff, 0xff, 0xcc, 0x00);
                break;
            }
        }

        private void OnListViewDrawSubItem(object? sender, DrawListViewSubItemEventArgs e) {
            if (e.SubItem == null) {
                e.DrawDefault = true;
                return;
            }
            DrawBackgroundAndGridLine(e);

            StringFormat stringFormat = StringFormat.GenericTypographic;
            stringFormat.LineAlignment = StringAlignment.Center;

            if (DrawTextIfAlignCenter(e, stringFormat)) {
                return;
            }

            stringFormat.Alignment = StringAlignment.Near;
            RectangleF bounds = e.Bounds;
            List<TipToken> tokens = TipParser.Execute(e.SubItem.Text);
            foreach (var token in tokens) {
                Brush brush;
                if (token.HasColor) {
                    brush = new SolidBrush(token.Color);
                } else {
                    brush = e.ColumnIndex == 0 ? BRUSH_FIRST_COLUMN_FOREGROUND : BRUSH_ROW_FOREGROUND;
                }

                var size = e.Graphics.MeasureString(token.Text, _listView.Font);
                RectangleF rc = bounds;
                rc.Width = size.Width;
                e.Graphics.DrawString(token.Text, _listView.Font, brush, rc, stringFormat);
                bounds.X += size.Width;
            }
        }

        private bool DrawTextIfAlignCenter(DrawListViewSubItemEventArgs e, StringFormat sf) {
            if (e.SubItem == null) {
                return false;
            }
            if (!(e.SubItem.Tag is SubItemTag)) {
                return false;
            }
            switch ((SubItemTag)e.SubItem.Tag) {
            case SubItemTag.Hotkey:
            case SubItemTag.Unhotkey:
            case SubItemTag.Researchhotkey:
                sf.Alignment = StringAlignment.Center;
                e.Graphics.DrawString(e.SubItem.Text, _listView.Font,
                    new SolidBrush(e.SubItem.ForeColor),
                    e.Bounds, sf);
                return true;
            }
            return false;
        }

        private static void DrawBackgroundAndGridLine(DrawListViewSubItemEventArgs e) {
            if (e.Item != null && e.Item.Selected) {
                e.Graphics.FillRectangle(Brushes.Navy, e.Bounds);
            } else {
                e.Graphics.FillRectangle(BRUSH_ROW_BACKGROUND, e.Bounds);
            }
            e.Graphics.DrawRectangle(PEN_GRID_LINE, e.Bounds);
        }

        private void OnListViewDrawColumnHeader(object? sender, DrawListViewColumnHeaderEventArgs e) {
            e.Graphics.FillRectangle(BRUSH_HEAD_BACKGROUND, e.Bounds);
            e.Graphics.DrawRectangle(PEN_GRID_LINE, e.Bounds);
            e.Graphics.DrawString(
                _listView.Columns[e.ColumnIndex].Text,
                _listView.Font,
                BRUSH_HEAD_FOREGROUND,
                e.Bounds);
        }
    }

    public readonly struct TipToken {
        public readonly bool HasColor;
        public readonly Color Color;
        public readonly string Text;
        public TipToken(string text, Color color) {
            this.Text = text;
            this.Color = color;
            this.HasColor = true;
        }
        public TipToken(string text) {
            this.Text = text;
            this.Color = Color.White;
            this.HasColor = false;
        }
    }

    public static class TipParser {
        private static readonly Regex REGEX_TIP = new Regex(
            @"\|c([a-fA-F0-9]{8})(.*?)\|r",
            RegexOptions.Compiled | RegexOptions.Singleline
        );

        private static Color ToColor(string argb) {
            return Color.FromArgb((int)Convert.ToUInt32(argb, 16));
        }

        public static List<TipToken> Execute(string text) {
            List<TipToken> result = new(4);
            var matches = REGEX_TIP.Matches(text);
            if (matches.Count <= 0) {
                result.Add(new TipToken(text));
                return result;
            }

            int idx = 0;
            foreach (Match m in matches) {
                int beforeColorLen = m.Index - idx;
                if (beforeColorLen > 0) {
                    result.Add(new TipToken(text.Substring(idx, beforeColorLen)));
                }
                string coloredText = m.Groups[2].Value;
                if (coloredText.Length > 0) {
                    Color color = ToColor(m.Groups[1].Value);
                    result.Add(new TipToken(coloredText, color));
                }
                idx += m.Length + beforeColorLen;
            }
            if (idx < text.Length) {
                result.Add(new TipToken(text.Substring(idx)));
            }

            return result;

        }
    }
}

