﻿using yhb_war3_custom_keys.model;
using yhb_war3_custom_keys.res;

namespace yhb_war3_custom_keys.view {
    public partial class FormChild : Form {

        private KeyDefines? _keyDefines;

        public FormChild() {
            InitializeComponent();
        }

        public static FormChild Create(Form mdiParent, string caption, KeyDefines keyDefins) {
            FormChild formChild = new FormChild {
                Text = caption,
                MdiParent = mdiParent,
                _keyDefines = keyDefins,
            };
            formChild.Show();
            return formChild;
        }

        private void FormChild_Load(object sender, EventArgs e) {
            if (_keyDefines == null) {
                throw new Exception("No key defines.");
            }
            InitializeGui(_keyDefines);
        }

        private void InitializeGui(KeyDefines keyDefines) {
            string[] subPageNames = new string[3];
            subPageNames[0] = Resources.S_PAGE_HEROES;
            subPageNames[1] = Resources.S_PAGE_UNITS;
            subPageNames[2] = Resources.S_PAGE_BUILDING;

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
                    TabPage subPage = new(subPageNames[idx]) {
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