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
            TabPagesInitializer.Execute(this.tabControlMain, _defaultKeyDefines);
        }

        private static class TabPagesInitializer {
            private static readonly string[] TabNames = {
                "Human", 
                "Orc",
                "Undead",
                "Night Elves",
                "Neutral",
                "Common",
            };
            private static readonly string[] GroupNames = {
                "Heroes", "Units", "Building",
            };

            public static void Execute(TabControl tabControl, KeyDefines keyDefines) {
                int index = 0;
                foreach (string name in TabNames) {
                    TabPage page = new TabPage(name) {
                        Parent = tabControl,
                        BackColor = Color.Black,
                        ForeColor = Color.White
                    };
                    var entries = KeyDefinesGroup.RACE_ENTRIES[index];

                    // Only one sub-page.
                    if (entries.Count == 1) {
                        new KeyDefineGui(keyDefines, page, entries[0]);
                        continue;
                    }

                    // Has three sub-pages.

                    TabControl tc = new TabControl {
                        Parent = page,
                        BackColor = page.BackColor,
                        ForeColor = page.ForeColor,
                        Dock = DockStyle.Fill,
                        Alignment = TabAlignment.Left,
                    };
                    int sub = 0;
                    foreach (string group in GroupNames) {
                        TabPage subPage = new TabPage(group) {
                            Parent = tc,
                            BackColor = page.BackColor,
                            ForeColor = page.ForeColor,
                        };
                        new KeyDefineGui(keyDefines, subPage, entries[sub++]);
                    }
                    ++index;
                }
            }
        }

        private void FormMain_Shown(object sender, EventArgs e) {

        }
    }
}