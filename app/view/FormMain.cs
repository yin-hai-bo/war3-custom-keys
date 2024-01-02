using System.Diagnostics;
using yhb_war3_custom_keys.model;
using yhb_war3_custom_keys.res;
using yhb_war3_custom_keys.view;

namespace yhb_war3_custom_keys {
    public partial class FormMain : Form {

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

            // The default key defines
            FormChild.Create(this, Resources.S_DEFAULT_KEY_DEFINES,
                KeyDefines.CreateFromString(Resources.CustomKeysSample_cn));

            CmdLine cmdLine = new CmdLine();
            try {
                cmdLine.Parse(Environment.GetCommandLineArgs());
            } catch(CmdLine.Exception ex) {
                ErrorBox.Show(this, ex.Message);
            }
            if (cmdLine.IsValid) {
                foreach (string filename in cmdLine.Files) {
                    TryToCreateFormChildFromFile(filename);
                }
            }
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
                FormChild.Create(this, filename, keyDefines);
            } catch (IOException ex) {
                ErrorBox.Show(this, ex.Message);
            }
        }

        private static string[]? GetFilenamesFromDrag(DragEventArgs e) {
            var data = e.Data;
            return data?.GetData("FileDrop") as string[];
        }
    }
}