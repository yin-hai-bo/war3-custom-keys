using System.Text.RegularExpressions;
using yhb_war3_custom_keys.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace yhb_war3_custom_keys.view {

    public static class KeyDefinesToListView {
        private static readonly Pen PEN_GRID_LINE = new Pen(Color.FromArgb(255, 80, 80, 80), 1);

        private static readonly Brush BRUSH_HEAD_BACKGROUND = new SolidBrush(Color.FromArgb(255, 40, 40, 50));
        private static readonly Brush BRUSH_HEAD_FOREGROUND = Brushes.White;

        private static readonly Brush BRUSH_ROW_BACKGROUND = Brushes.Black;
        private static readonly Brush BRUSH_ROW_FOREGROUND = Brushes.White;

        private enum SubItemTag {
            Hotkey,
            Unhotkey,
            Researchhotkey,
            Tip,
        }

        public static void Execute(KeyDefines keyDefines, Control parent, IReadOnlyCollection<KeyDefinesCategory.Entry> entries) {
            ListView listView = new() {
                Parent = parent,
                Dock = DockStyle.Fill,
                View = View.Details,
                HeaderStyle = ColumnHeaderStyle.Nonclickable,
                OwnerDraw = true,
                BackColor = Color.Black,
                ForeColor = Color.White,
                FullRowSelect = true
            };
            listView.DrawColumnHeader += OnListViewDrawColumnHeader;
            listView.DrawItem += OnListViewDrawItem;
            listView.DrawSubItem += OnListViewDrawSubItem;

            listView.BeginUpdate();
            AddEntriesToListView(keyDefines, entries, listView);
            listView.EndUpdate();
        }

        private static void AddEntriesToListView(
            KeyDefines keyDefines,
            IReadOnlyCollection<KeyDefinesCategory.Entry> entries,
            ListView listView) {

            var columns = listView.Columns;
            columns.Add(string.Empty);
            columns.Add("Hotkey").TextAlign = HorizontalAlignment.Center;
            columns.Add("Unhotkey").TextAlign = HorizontalAlignment.Center;
            columns.Add("Researchhotkey").TextAlign = HorizontalAlignment.Center;
            columns.Add("Tip");

            foreach (var entry in entries) {
                var section = keyDefines.GetSection(entry.SectionName);
                if (section != null) {
                    var row = listView.Items.Add(entry.Description);
                    AddSubItem(row, section.Find("Hotkey"), SubItemTag.Hotkey);
                    AddSubItem(row, section.Find("Unhhotkey"), SubItemTag.Unhotkey);
                    AddSubItem(row, section.Find("Researchhotkey"), SubItemTag.Researchhotkey);
                    AddSubItem(row, section.Find("Tip"), SubItemTag.Tip);
                }
            }
            foreach (ColumnHeader col in columns) {
                col.Width = -2;
            }
        }

        private static void OnListViewDrawItem(object? sender, DrawListViewItemEventArgs e) {
        }

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

        private static void OnListViewDrawSubItem(object? sender, DrawListViewSubItemEventArgs e) {
            if (e.SubItem == null) {
                e.DrawDefault = true;
                return;
            }
            DrawBackgroundAndGridLine(e);

            StringFormat sf = StringFormat.GenericTypographic;
            sf.LineAlignment = StringAlignment.Center;

            ListView? listView = sender as ListView;
            if (listView == null) {
                e.DrawDefault = true;
                return;
            }
            if (DrawTextIfAlignCenter(listView, e, sf)) {
                return;
            }

            sf.Alignment = StringAlignment.Near;
            RectangleF bounds = e.Bounds;
            List<TipToken> tokens = TipParser.Execute(e.SubItem.Text);
            foreach (var token in tokens) {
                Brush brush;
                if (token.HasColor) {
                    brush = new SolidBrush(token.Color);
                } else {
                    brush = BRUSH_ROW_FOREGROUND;
                }

                var size = e.Graphics.MeasureString(token.Text, listView.Font);
                RectangleF rc = bounds;
                rc.Width = size.Width;
                e.Graphics.DrawString(token.Text, listView.Font, brush, rc, sf);
                bounds.X += size.Width;
            }
        }

        private static bool DrawTextIfAlignCenter(ListView listView, DrawListViewSubItemEventArgs e, StringFormat sf) {
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
                    e.Graphics.DrawString(e.SubItem.Text, listView.Font,
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

        private static void OnListViewDrawColumnHeader(object? sender, DrawListViewColumnHeaderEventArgs e) {
            ListView? listView = sender as ListView;
            if (listView == null) {
                e.DrawDefault = true;
                return;
            }
            e.Graphics.FillRectangle(BRUSH_HEAD_BACKGROUND, e.Bounds);
            e.Graphics.DrawRectangle(PEN_GRID_LINE, e.Bounds);
            e.Graphics.DrawString(
                listView.Columns[e.ColumnIndex].Text,
                new Font(listView.Font, FontStyle.Bold),
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

