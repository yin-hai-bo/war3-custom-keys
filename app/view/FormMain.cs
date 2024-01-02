using System.Diagnostics;
using yhb_war3_custom_keys.model;
using yhb_war3_custom_keys.res;
using yhb_war3_custom_keys.view;

namespace yhb_war3_custom_keys {
    public partial class FormMain : Form {

        public FormMain() {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e) {
            this.Text = Resources.S_APP_NAME;
            FormChild.Create(
                this,
                Resources.S_DEFAULT_KEY_DEFINES,
                KeyDefines.CreateFromString(Resources.CustomKeysSample_cn));
        }

        private void FormMain_Shown(object sender, EventArgs e) {

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
                try {
                    KeyDefines keyDefines = KeyDefines.CreateFromFile(filename);
                    FormChild.Create(this, filename, keyDefines);
                } catch (IOException ex) {
                    ErrorBox.Show(this, ex.Message);
                }
            }
        }

        private static string[]? GetFilenamesFromDrag(DragEventArgs e) {
            var data = e.Data;
            if (data == null) {
                return null;
            }
            return data.GetData("FileDrop") as string[];
        }
    }
}