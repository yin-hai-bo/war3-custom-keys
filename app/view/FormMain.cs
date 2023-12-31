using yhb_war3_custom_keys.model;
using yhb_war3_custom_keys.view;
using yhb_war3_custom_keys.res;

namespace yhb_war3_custom_keys{
    public partial class FormMain : Form {

        private readonly KeyDefines _defaultKeyDefines;

        public FormMain() {
            InitializeComponent();
            _defaultKeyDefines = KeyDefines.CreateFromString(Resources.CustomKeysSample_cn);
        }

        private void FormMain_Load(object sender, EventArgs e) {
            this.Text = Resources.S_APP_NAME;
            new KeyDefineGui(this.tabCommon, _defaultKeyDefines);
        }
    }
}