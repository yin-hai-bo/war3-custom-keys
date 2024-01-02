using System;
using System.Collections.Generic;
using yhb_war3_custom_keys.res;
namespace yhb_war3_custom_keys.view {
    public partial class DialogAskSave : Form {

        public string? Filename { get; private set; }

        private DialogAskSave(string? filename) {
            Filename = filename;
            InitializeComponent();
        }

        public static DialogResult ShowModal(string? filename) {
            DialogAskSave dialog = new DialogAskSave(filename);
            return dialog.ShowDialog();
        }

        private void DialogAskSave_Load(object sender, EventArgs e) {
            imageIcon.Image = SystemIcons.Warning.ToBitmap();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog() {
                Title = Resources.S_SAVE,
                CheckPathExists = true,
                OverwritePrompt = true,
                FileName = this.Filename,
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                this.Filename = saveFileDialog.FileName;
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.No;
        }

        private void btnDonotClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
