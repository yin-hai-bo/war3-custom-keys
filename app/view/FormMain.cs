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
            TabPagesInitializer.Execute(tabControlMain, _defaultKeyDefines);
        }

        private static class TabPagesInitializer {
            private static readonly string[] SUB_PAGE_NAMES = {
                "Heroes", "Units", "Building",
            };

            public static void Execute(TabControl tabControl, KeyDefines keyDefines) { 
                foreach (KeyDefinesGroup.Category category in KeyDefinesGroup.CategoryList) {
                    TabPage page = new(category.Name) {
                        Parent = tabControl,
                        BackColor = Color.Black,
                        ForeColor = Color.White
                    };

                    if (category.KindCount == 1) {
                        IEnumerator<KeyDefinesGroup.Entry[]> it = category.GetEnumerator();
                        it.MoveNext();
                        KeyDefinesToListView.Execute(keyDefines, page, it.Current);
                        continue;
                    }

                    TabControl tc = new() {
                        Parent = page,
                        BackColor = page.BackColor,
                        ForeColor = page.ForeColor,
                        Dock = DockStyle.Fill,
                        Alignment = TabAlignment.Left,
                    };
                    int idx = 0;
                    foreach (KeyDefinesGroup.Entry[] entries in category) {
                        TabPage subPage = new(SUB_PAGE_NAMES[idx]) {
                            Parent = tc,
                            BackColor = page.BackColor,
                            ForeColor = page.ForeColor,
                        };
                        KeyDefinesToListView.Execute(keyDefines, subPage, entries);
                        ++idx;
                    }
                }
            }
        }

        private void FormMain_Shown(object sender, EventArgs e) {

        }
    }
}