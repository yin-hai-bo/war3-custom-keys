﻿using yhb_war3_custom_keys.model;
using yhb_war3_custom_keys.res;

namespace yhb_war3_custom_keys.view {
    public partial class FormChild : Form {

        private KeyDefines? _keyDefines;
        public string? Filename { get; private set; }
        public bool Readonly { get; private set; }
        public bool NeedSave { get; private set; }

        private readonly List<KeyDefinesToListView> _listViews = new(6);

        public FormChild() {
            InitializeComponent();
        }

        public static FormChild Create(Form mdiParent, string caption, KeyDefines keyDefins, string? filename, bool readOnly) {
            FormChild formChild = new FormChild {
                Text = caption,
                MdiParent = mdiParent,
                _keyDefines = keyDefins,
                Filename = filename,
                Readonly = readOnly,
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

        private void OnListViewDoubleClick(KeyDefinesToListView _, ListViewItem item, KeyDefinesCategory.Entry entry) {
            FormEdit.ShowModal(this.MdiParent, entry);
        }

        private void InitializeGui(KeyDefines keyDefines) {
            string[] subPageNames = new string[3];
            subPageNames[0] = Resources.S_PAGE_HEROES;
            subPageNames[1] = Resources.S_PAGE_UNITS;
            subPageNames[2] = Resources.S_PAGE_BUILDING;

            foreach (KeyDefinesCategory.Category category in KeyDefinesCategory.CategoryList) {
                TabPage page = new(category.Name) {
                    Parent = tabControl,
                    BackColor = Color.Black,
                    ForeColor = Color.White
                };

                if (category.KindCount == 1) {
                    IEnumerator<KeyDefinesCategory.Entry[]> it = category.GetEnumerator();
                    it.MoveNext();
                    CreateNewListView(page, keyDefines, it.Current);
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
                foreach (KeyDefinesCategory.Entry[] entries in category) {
                    TabPage subPage = new(subPageNames[idx]) {
                        Parent = tc,
                        BackColor = page.BackColor,
                        ForeColor = page.ForeColor,
                    };
                    CreateNewListView(subPage, keyDefines, entries);
                    ++idx;
                }
            }
        }

        private void CreateNewListView(TabPage page, KeyDefines keyDefines, IReadOnlyCollection<KeyDefinesCategory.Entry> entries) {
            this._listViews.Add(new KeyDefinesToListView(page, keyDefines, entries, OnListViewDoubleClick));
        }

        private void FormChild_FormClosing(object sender, FormClosingEventArgs e) {
            if (this.NeedSave) {
                DialogResult dr = DialogAskSave.ShowModal(this.Filename);
                if (dr == DialogResult.Yes) {
                    // TODO: Save
                } else if (dr == DialogResult.No) {
                    // Discard change, close window.
                    return;
                } else {
                    // Don't close
                    e.Cancel = true;
                    return;
                }
            }

            foreach (var lv in this._listViews) {
                lv.Dispose();
            }
            this._listViews.Clear();
        }
    }
}
