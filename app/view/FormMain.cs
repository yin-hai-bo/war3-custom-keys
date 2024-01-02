using System.Diagnostics;
using System.Globalization;
using yhb_war3_custom_keys.model;
using yhb_war3_custom_keys.res;
using yhb_war3_custom_keys.view;

namespace yhb_war3_custom_keys {
    public partial class FormMain : Form {

        private int _newDocCount;

        private bool _firstShown = true;

        public FormMain() {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e) {
            this.Text = Resources.S_APP_NAME;
        }

        private void FormMain_Shown(object sender, EventArgs e) {
            if (!_firstShown) {
                return;
            }
            _firstShown = false;

            // The default key defines.
            FormChild.Create(this, Resources.S_DEFAULT_KEY_DEFINES, CreateDefaultKeyDefines(), "", true);

            // Open the file specified on the command line.
            CmdLine cmdLine = new CmdLine();
            try {
                cmdLine.Parse(Environment.GetCommandLineArgs());
            } catch (CmdLine.Exception ex) {
                ErrorBox.Show(this, ex.Message);
            }
            if (cmdLine.IsValid) {
                foreach (string filename in cmdLine.Files) {
                    TryToCreateFormChildFromFile(filename);
                }
            }
        }

        private static KeyDefines CreateDefaultKeyDefines() {
            string content;
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            if (currentCulture.Name == "zh-CN" || currentCulture.Name == "zh-SG") {
                content = Resources.CustomKeysSample_cn;
            } else {
                content = Resources.CustomKeysSample;
            }
            return KeyDefines.CreateFromString(content);
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e) {
            e.Effect = (GetFilenamesFromDrag(e) == null)
                ? DragDropEffects.None : DragDropEffects.Copy;
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e) {
            string[]? files = GetFilenamesFromDrag(e);
            if (files == null) {
                return;
            }
            foreach (string filename in files) {
                TryToCreateFormChildFromFile(filename);
            }
        }

        private void TryToCreateFormChildFromFile(string filename) {
            try {
                KeyDefines keyDefines = KeyDefines.CreateFromFile(filename);
                FormChild.Create(this, filename, keyDefines, filename, false);
            } catch (IOException ex) {
                ErrorBox.Show(this, ex.Message);
            }
        }

        private static string[]? GetFilenamesFromDrag(DragEventArgs e) {
            var data = e.Data;
            return data?.GetData("FileDrop") as string[];
        }

        private void newMenu_Click(object sender, EventArgs e) {
            ++_newDocCount;
            FormChild.Create(this,
                string.Format(Resources.S_UNTITLED, _newDocCount),
                CreateDefaultKeyDefines(),
                null, false);
        }

        private void openMenu_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new() {
                Multiselect = true,
                Filter = Resources.S_OPEN_FILE_DIALOG_FILTER,
                CheckPathExists = true,
                CheckFileExists = true,
            };
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                foreach (var file in dlg.FileNames) {
                    TryToCreateFormChildFromFile(file);
                }
            }
        }

        private void fileMenu_DropDownOpening(object sender, EventArgs e) {
            if (this.ActiveMdiChild is not FormChild child) {
                saveMenu.Enabled = false;
            } else {
                saveMenu.Enabled = child.NeedSave;
            }
        }

        private void exitMenu_Click(object sender, EventArgs e) {
            Close();
        }
    }
}