using yhb_war3_custom_keys.model;

namespace yhb_war3_custom_keys.view {
    public partial class FormChild : Form {

        private KeyDefines _keyDefins;

        public FormChild() {
            InitializeComponent();
        }

        public static FormChild Create(Form mdiParent, string caption, KeyDefines keyDefins) {
            FormChild formChild = new FormChild {
                Text = caption,
                MdiParent = mdiParent,
                _keyDefins = keyDefins,
            };
            formChild.Show();
            return formChild;
        }

        private void FormChild_Load(object sender, EventArgs e) {
            TabPagesInitializer.Execute(tabControl, _keyDefins);
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
    }
}
