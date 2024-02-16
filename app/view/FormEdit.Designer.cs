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
            editUnhotkey = new TextBox();
            label2 = new Label();
            editHotky = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(editUnhotkey);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(editHotky);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 271);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // editUnhotkey
            // 
            editUnhotkey.Location = new Point(101, 71);
            editUnhotkey.MaxLength = 1;
            editUnhotkey.Name = "editUnhotkey";
            editUnhotkey.Size = new Size(65, 23);
            editUnhotkey.TabIndex = 4;
            editUnhotkey.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(30, 74);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 3;
            label2.Text = "UnHotkey";
            // 
            // editHotky
            // 
            editHotky.Location = new Point(101, 42);
            editHotky.MaxLength = 1;
            editHotky.Name = "editHotky";
            editHotky.Size = new Size(65, 23);
            editHotky.TabIndex = 2;
            editHotky.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(46, 45);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 0;
            label1.Text = "Hotkey";
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
        private Label label1;
        private TextBox editHotky;
        private TextBox editUnhotkey;
        private Label label2;
    }
}