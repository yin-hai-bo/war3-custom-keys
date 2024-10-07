using System.Text.RegularExpressions;
using yhb_war3_custom_keys.model;
using yhb_war3_custom_keys.res;

namespace yhb_war3_custom_keys.view {
    public partial class FormEdit : Form {

        private readonly Section _section;

        private FormEdit(string caption, Section section) {
            _section = section;
            InitializeComponent();
            this.Text = caption;
            groupBox1.Text = _section.Description ?? _section.Name;
        }

        internal static DialogResult ShowModal(IWin32Window owner, string caption, Section section) {
            FormEdit form = new(caption, section);
            return form.ShowDialog(owner);
        }

        private void FormEdit_Load(object sender, EventArgs e) {
            editHotkey.Text = _section.Find("Hotkey");
            editUnhotkey.Text = _section.Find("UnhotKey");
            SetTip();
        }

        private void SetTip() {
            string? tip = _section.Find("Tip");
            if (tip == null) {
                editTip.Clear();
                richTipPreview.Clear();
                return;
            }

            editTip.Text = tip;

            List<TipToken> tokens = TipParser.Execute(tip);
            foreach (TipToken token in tokens) {
                richTipPreview.AppendText(token.Text);
                int len = token.Text.Length;
                richTipPreview.SelectionStart = richTipPreview.Text.Length - len;
                richTipPreview.SelectionLength = len;
                richTipPreview.SelectionColor = token.Color;
            }
        }

        private bool CheckHotkeys(TextBox box, bool allowEmpty) {
            do {
                if (!allowEmpty && box.Text.Length == 0) {
                    break;
                }
                if (HotkeysChecker.Execute(box.Text)) {
                    errorProvider1.Clear();
                    return true;
                }
            } while (false);
            errorProvider1.SetError(box, Resources.S_INVALID_HOTKEY_DEFINE);
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (!CheckHotkeys(editHotkey, false)
                || !CheckHotkeys(editUnhotkey, true)) {
                return;
            }
            this.Close();
        }

        public static class HotkeysChecker {

            private static bool IsLetter(char ch) {
                return (ch >= 'a' && ch <= 'z')
                    || (ch >= 'A' && ch <= 'Z');
            }

            public static bool Execute(string text) {
                if (string.IsNullOrEmpty(text)) {
                    return true;
                }
                for (int start = 0; ;) {
                    string? token = ExtractToken(text, ref start);
                    if (token == null) {
                        return text[^1] != ',';
                    }
                    if (token.Length == 0) {
                        return false;
                    }
                    if (token.Length == 1 && IsLetter(token[0])) {
                        continue;
                    }
                    if (token.Length > 3) {
                        return false;
                    }
                    if (!uint.TryParse(token, out uint ascii) || ascii > 127) {
                        return false;
                    }
                }
            }

            private static string? ExtractToken(string s, ref int start) {
                if (start >= s.Length) {
                    return null;
                }
                int i = start;
                for (int len = s.Length; i < len; ++i) {
                    char ch = s[i];
                    if (ch == ',') {
                        break;
                    }
                }
                string result = s[start..i];
                start = i + 1;
                return result;
            }
        }

    }
}
