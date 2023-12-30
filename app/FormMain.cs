using yhb_war3_custom_keys.model;
using yhb_war3_custom_keys.view;

namespace yhb_war3_custom_keys{
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e) {
            try {
                KeyDefines.CreateoDefaultInstance();
            } catch (IOException ex) {
                ErrorBox.Show(this, ex.Message);
            }
        }
    }
}