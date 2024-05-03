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
            groupBox1 = new GroupBox();
            editTip = new TextBox();
            labelTip = new Label();
            editUnhotkey = new TextBox();
            labelUnHotKey = new Label();
            editHotky = new TextBox();
            labelHotKey = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(editTip);
            groupBox1.Controls.Add(labelTip);
            groupBox1.Controls.Add(editUnhotkey);
            groupBox1.Controls.Add(labelUnHotKey);
            groupBox1.Controls.Add(editHotky);
            groupBox1.Controls.Add(labelHotKey);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(549, 208);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // editTip
            // 
            editTip.BackColor = Color.Black;
            editTip.ForeColor = Color.White;
            editTip.Location = new Point(104, 88);
            editTip.MaxLength = 1;
            editTip.Multiline = true;
            editTip.Name = "editTip";
            editTip.ScrollBars = ScrollBars.Vertical;
            editTip.Size = new Size(382, 82);
            editTip.TabIndex = 6;
            editTip.TextAlign = HorizontalAlignment.Center;
            // 
            // labelTip
            // 
            labelTip.ForeColor = SystemColors.ControlText;
            labelTip.Location = new Point(18, 91);
            labelTip.Name = "labelTip";
            labelTip.Size = new Size(80, 17);
            labelTip.TabIndex = 5;
            labelTip.Text = "Tip";
            labelTip.TextAlign = ContentAlignment.MiddleRight;
            // 
            // editUnhotkey
            // 
            editUnhotkey.Location = new Point(104, 59);
            editUnhotkey.MaxLength = 1;
            editUnhotkey.Name = "editUnhotkey";
            editUnhotkey.Size = new Size(65, 23);
            editUnhotkey.TabIndex = 4;
            editUnhotkey.TextAlign = HorizontalAlignment.Center;
            // 
            // labelUnHotKey
            // 
            labelUnHotKey.ForeColor = SystemColors.ControlText;
            labelUnHotKey.Location = new Point(18, 62);
            labelUnHotKey.Name = "labelUnHotKey";
            labelUnHotKey.Size = new Size(80, 17);
            labelUnHotKey.TabIndex = 3;
            labelUnHotKey.Text = "UnHotkey";
            labelUnHotKey.TextAlign = ContentAlignment.MiddleRight;
            // 
            // editHotky
            // 
            editHotky.Location = new Point(104, 30);
            editHotky.MaxLength = 1;
            editHotky.Name = "editHotky";
            editHotky.Size = new Size(65, 23);
            editHotky.TabIndex = 2;
            editHotky.TextAlign = HorizontalAlignment.Center;
            // 
            // labelHotKey
            // 
            labelHotKey.ForeColor = SystemColors.ControlText;
            labelHotKey.Location = new Point(18, 33);
            labelHotKey.Name = "labelHotKey";
            labelHotKey.Size = new Size(80, 17);
            labelHotKey.TabIndex = 0;
            labelHotKey.Text = "Hotkey";
            labelHotKey.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 382);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEdit";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += FormEdit_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelHotKey;
        private TextBox editHotky;
        private TextBox editUnhotkey;
        private Label labelUnHotKey;
        private TextBox editTip;
        private Label labelTip;
    }
}