namespace yhb_war3_custom_keys.view {
    partial class DialogAskSave {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogAskSave));
            imageIcon = new PictureBox();
            labelMessage = new Label();
            btnSave = new Button();
            btnDiscard = new Button();
            btnDonotClose = new Button();
            ((System.ComponentModel.ISupportInitialize)imageIcon).BeginInit();
            SuspendLayout();
            // 
            // imageIcon
            // 
            resources.ApplyResources(imageIcon, "imageIcon");
            imageIcon.Name = "imageIcon";
            imageIcon.TabStop = false;
            // 
            // labelMessage
            // 
            resources.ApplyResources(labelMessage, "labelMessage");
            labelMessage.Name = "labelMessage";
            // 
            // btnSave
            // 
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDiscard
            // 
            resources.ApplyResources(btnDiscard, "btnDiscard");
            btnDiscard.Name = "btnDiscard";
            btnDiscard.UseVisualStyleBackColor = true;
            btnDiscard.Click += btnDiscard_Click;
            // 
            // btnDonotClose
            // 
            resources.ApplyResources(btnDonotClose, "btnDonotClose");
            btnDonotClose.Name = "btnDonotClose";
            btnDonotClose.UseVisualStyleBackColor = true;
            btnDonotClose.Click += btnDonotClose_Click;
            // 
            // DialogAskSave
            // 
            AcceptButton = btnSave;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnDonotClose;
            Controls.Add(btnDonotClose);
            Controls.Add(btnDiscard);
            Controls.Add(btnSave);
            Controls.Add(labelMessage);
            Controls.Add(imageIcon);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DialogAskSave";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += DialogAskSave_Load;
            ((System.ComponentModel.ISupportInitialize)imageIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imageIcon;
        private Label labelMessage;
        private Button btnSave;
        private Button btnDiscard;
        private Button btnDonotClose;
    }
}