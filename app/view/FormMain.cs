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
            InitializeAllTables();
        }

        private void InitializeAllTables() {
            string[] TabNames = {
                "Human", 
                "Orc",
                // "Undead", "Night Elves",
                "Common",
            };
            string[] GroupNames = {
                "Heroes", "Units", "Building",
            };
            int index = 0;
            foreach (string name in TabNames) {

                // Human, Orc, Undead, Night Elves, or Common
                TabPage page = new TabPage(name) {
                    Parent = this.tabControlMain,
                    BackColor = Color.Black,
                    ForeColor = Color.White
                };

                if (tabControlMain.TabCount >= TabNames.Length) {
                    new KeyDefineGui(_defaultKeyDefines, page, KeyDefinesGroup.COMMON_ENTRIES);
                    continue;
                }

                TabControl tc = new TabControl {
                    Parent = page,
                    BackColor = page.BackColor,
                    ForeColor = page.ForeColor,
                    Dock = DockStyle.Fill,
                    Alignment = TabAlignment.Left,
                };
                var race = KeyDefinesGroup.RACE_ENTRIES[index];
                int sub = 0;
                foreach (string group in GroupNames) {
                    TabPage subPage = new TabPage(group) {
                        Parent = tc,
                        BackColor = page.BackColor,
                        ForeColor = page.ForeColor,
                    };
                    new KeyDefineGui(_defaultKeyDefines, subPage, race[sub++]);
                }
                ++index;
            }
        }

        private void FormMain_Shown(object sender, EventArgs e) {

        }
    }
}