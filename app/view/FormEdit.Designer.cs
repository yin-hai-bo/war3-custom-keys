namespace yhb_war3_custom_keys.view {
    partial class FormEdit {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
            groupBox1 = new GroupBox();
            labelTipPreview = new Label();
            richTipPreview = new RichTextBox();
            editTip = new TextBox();
            labelTip = new Label();
            editUnhotkey = new TextBox();
            labelUnHotKey = new Label();
            editHotkey = new TextBox();
            labelHotKey = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(labelTipPreview);
            groupBox1.Controls.Add(richTipPreview);
            groupBox1.Controls.Add(editTip);
            groupBox1.Controls.Add(labelTip);
            groupBox1.Controls.Add(editUnhotkey);
            groupBox1.Controls.Add(labelUnHotKey);
            groupBox1.Controls.Add(editHotkey);
            groupBox1.Controls.Add(labelHotKey);
            groupBox1.ForeColor = SystemColors.ControlText;
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // labelTipPreview
            // 
            labelTipPreview.ForeColor = SystemColors.ControlText;
            resources.ApplyResources(labelTipPreview, "labelTipPreview");
            labelTipPreview.Name = "labelTipPreview";
            // 
            // richTipPreview
            // 
            richTipPreview.BackColor = Color.Black;
            richTipPreview.ForeColor = Color.White;
            resources.ApplyResources(richTipPreview, "richTipPreview");
            richTipPreview.Name = "richTipPreview";
            richTipPreview.ReadOnly = true;
            // 
            // editTip
            // 
            editTip.BackColor = SystemColors.Window;
            editTip.ForeColor = SystemColors.WindowText;
            resources.ApplyResources(editTip, "editTip");
            editTip.Name = "editTip";
            // 
            // labelTip
            // 
            labelTip.ForeColor = SystemColors.ControlText;
            resources.ApplyResources(labelTip, "labelTip");
            labelTip.Name = "labelTip";
            // 
            // editUnhotkey
            // 
            resources.ApplyResources(editUnhotkey, "editUnhotkey");
            editUnhotkey.Name = "editUnhotkey";
            // 
            // labelUnHotKey
            // 
            labelUnHotKey.ForeColor = SystemColors.ControlText;
            resources.ApplyResources(labelUnHotKey, "labelUnHotKey");
            labelUnHotKey.Name = "labelUnHotKey";
            // 
            // editHotkey
            // 
            resources.ApplyResources(editHotkey, "editHotkey");
            editHotkey.Name = "editHotkey";
            // 
            // labelHotKey
            // 
            labelHotKey.ForeColor = SystemColors.ControlText;
            resources.ApplyResources(labelHotKey, "labelHotKey");
            labelHotKey.Name = "labelHotKey";
            // 
            // btnSave
            // 
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormEdit
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEdit";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += FormEdit_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelHotKey;
        private TextBox editHotkey;
        private TextBox editUnhotkey;
        private Label labelUnHotKey;
        private TextBox editTip;
        private Label labelTip;
        private RichTextBox richTipPreview;
        private Label labelTipPreview;
        private Button btnSave;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
    }
}