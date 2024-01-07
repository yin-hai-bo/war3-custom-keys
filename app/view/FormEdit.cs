using yhb_war3_custom_keys.model;

namespace yhb_war3_custom_keys.view {
    public partial class FormEdit : Form {
        private FormEdit() {
            InitializeComponent();
        }

        internal static DialogResult ShowModal(IWin32Window owner, KeyDefinesCategory.Entry entry) {
            FormEdit form = new FormEdit();
            form.Text = entry.Description;
            form.labelName.Text = entry.Description;
            return form.ShowDialog(owner);
        }
    }
}
