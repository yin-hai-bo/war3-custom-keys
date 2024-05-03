using yhb_war3_custom_keys.model;

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
            editHotky.Text = _section.Find("Hotkey");
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
    }
}
