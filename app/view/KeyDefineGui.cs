using System.Diagnostics;
using System.Text.RegularExpressions;
using yhb_war3_custom_keys.model;

namespace yhb_war3_custom_keys.view {
    public class KeyDefineGui {
        private static readonly Brush brushHeadBackground = new SolidBrush(Color.Gray);
        private static readonly Brush brushHeadForeground = new SolidBrush(Color.Black);

        private static readonly Brush BRUSH_ROW_BACKGROUND = new SolidBrush(Color.Black);
        private static readonly Brush BRUSH_ROW_FOREGROUND = new SolidBrush(Color.White);

        private readonly ListView _listView;

        private enum SubItemTag {
            Hotkey,
            Unhotkey,
            Tip,
        }

        private struct Entry {
            public readonly string SectionName;
            public readonly string Description;
            public Entry(string secitonName, string caption) {
                this.SectionName = secitonName;
                this.Description = caption;
            }
        }

        private static readonly Entry[] entries = new Entry[] {
            new("CmdMove", "移动"),
            new("CmdAttack", "攻击"),
            new("CmdAttackGround", "攻击地面"),
            new("CmdBuild", "建造建筑物（一般的）"),
            new("CmdBuildHuman", "建造建筑物（人类）"),
            new("CmdBuildOrc", "建造建筑物（兽族）"),
            new("CmdBuildNightElf", "建造建筑物（暗夜精灵）"),
            new("CmdBuildUndead", "召唤建筑物（亡灵）"),
            new("CmdCancel", "取消"),
            new("CmdCancelBuild", "取消建造"),
            new("CmdCancelTrain", "取消训练"),
            new("CmdCancelRevive", "取消复活"),
            new("CmdHoldPos", "保持原位"),
            new("CmdPatrol", "巡逻"),
            new("CmdRally", "设集结点"),
            new("CmdSelectSkill", "英雄技能"),
            new("CmdStop", "停止"),
            new("Ahar", "采集"),
            new("Ahrl", "采集木材"),
            new("Arep", "农民修理技能"),
            new("Anei", "中立单位的互动（选择用户命令）"),
            new("Aloa", "装载"),
            new("Adro", "卸载全部"),
            new("Sdro", "卸载（海上运输工具）"),
        };

        public KeyDefineGui(Control parent, KeyDefines keyDefines) {
            _listView = new ListView();
            _listView.Parent = parent;
            _listView.Dock = DockStyle.Fill;
            _listView.View = View.Details;
            _listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            _listView.OwnerDraw = true;
            _listView.BackColor = Color.Black;
            _listView.ForeColor = Color.White;

            _listView.DrawColumnHeader += this.OnListViewDrawColumnHeader;
            _listView.DrawItem += this.OnListViewDrawItem;
            _listView.DrawSubItem += this.OnListViewDrawSubItem;


            _listView.Columns.Add("", -1);
            _listView.Columns.Add("Hotkey", -2);
            _listView.Columns.Add("Unhotkey", -2);
            _listView.Columns.Add("Tip", -1);

            foreach (var entry in entries) {
                var section = keyDefines.GetSection(entry.SectionName);
                if (section != null) {
                    var row = _listView.Items.Add(entry.Description);
                    AddSubItem(row, section.Find("Hotkey"), SubItemTag.Hotkey);
                    AddSubItem(row, section.Find("Unhhotkey"), SubItemTag.Unhotkey);
                    AddSubItem(row, section.Find("Tip"), SubItemTag.Tip);
                }
            }
        }

        private static void AddSubItem(ListViewItem row, string? text, SubItemTag tag) {
            var subItem = row.SubItems.Add(text);
            subItem.Tag = tag;
            switch (tag) {
            case SubItemTag.Hotkey:
            case SubItemTag.Unhotkey:
                subItem.ForeColor = Color.FromArgb(0xff, 0xff, 0xcc, 0x00);
                break;
            }
        }



        private void OnListViewDrawSubItem(object? sender, DrawListViewSubItemEventArgs e) {
            var subItem = e.SubItem;
            if (subItem == null) {
                e.DrawDefault = true;
                return;
            }
            if (subItem.Tag == null || (SubItemTag)subItem.Tag != SubItemTag.Tip) {
                e.DrawDefault = true;
                return;
            }

            RectangleF bounds = e.Bounds;
            e.Graphics.FillRectangle(BRUSH_ROW_BACKGROUND, bounds);

            List<TipToken> tokens = TipParser.Execute(subItem.Text);
            foreach (var token in tokens) {
                Brush brush;
                if (token.HasColor) {
                    brush = new SolidBrush(token.Color);
                } else {
                    brush = BRUSH_ROW_FOREGROUND;
                }

                var size = e.Graphics.MeasureString(token.Text, _listView.Font);
                RectangleF rc = bounds;
                rc.Width = size.Width;
                e.Graphics.DrawString(token.Text, _listView.Font, brush, rc);
                bounds.X += size.Width;
                Debug.Write(token.Text);
            }
            Debug.WriteLine(null);
        }

        private void OnListViewDrawItem(object? sender, DrawListViewItemEventArgs e) {
            //e.DrawDefault = true;
        }

        private void OnListViewDrawColumnHeader(object? sender, DrawListViewColumnHeaderEventArgs e) {
            e.Graphics.FillRectangle(brushHeadBackground, e.Bounds);
            e.Graphics.DrawString(
                _listView.Columns[e.ColumnIndex].Text,
                _listView.Font,
                brushHeadForeground,
                e.Bounds);
        }
    }

    public struct TipToken {
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

