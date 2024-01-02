using yhb_war3_custom_keys.model;
using yhb_war3_custom_keys.res;
using yhb_war3_custom_keys.view;

namespace yhb_war3_custom_keys {
    public partial class FormMain : Form {

        public FormMain() {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e) {
            this.Text = Resources.S_APP_NAME;
            FormChild.Create(
                this,
                Resources.S_DEFAULT_KEY_DEFINES,                
                KeyDefines.CreateFromString(Resources.CustomKeysSample_cn));
        }

        private void FormMain_Shown(object sender, EventArgs e) {

        }
    }
}