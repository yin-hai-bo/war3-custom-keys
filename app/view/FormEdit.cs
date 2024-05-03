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
            editTip.Text = _section.Find("Tip");
        }
    }
}
