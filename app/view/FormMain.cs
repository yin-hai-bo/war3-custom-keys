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
            new KeyDefineGui(_defaultKeyDefines, tabHumanHeroes, KeyDefinesGroup.HUMAN_HERO_ENTRIES);
            new KeyDefineGui(_defaultKeyDefines, this.tabCommon, KeyDefinesGroup.COMMON_ENTRIES);
        }

        private void FormMain_Shown(object sender, EventArgs e) {

        }
    }
}