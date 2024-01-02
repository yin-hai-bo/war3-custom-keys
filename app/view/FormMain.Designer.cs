namespace yhb_war3_custom_keys {
    partial class FormMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            mainMenu = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            newMenu = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            openMenu = new ToolStripMenuItem();
            saveMenu = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitMenu = new ToolStripMenuItem();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { fileMenu });
            resources.ApplyResources(mainMenu, "mainMenu");
            mainMenu.Name = "mainMenu";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { newMenu, toolStripSeparator1, openMenu, saveMenu, toolStripMenuItem1, exitMenu });
            fileMenu.Name = "fileMenu";
            resources.ApplyResources(fileMenu, "fileMenu");
            fileMenu.DropDownOpening += fileMenu_DropDownOpening;
            // 
            // newMenu
            // 
            newMenu.Name = "newMenu";
            resources.ApplyResources(newMenu, "newMenu");
            newMenu.Click += newMenu_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // openMenu
            // 
            openMenu.Name = "openMenu";
            resources.ApplyResources(openMenu, "openMenu");
            openMenu.Click += openMenu_Click;
            // 
            // saveMenu
            // 
            saveMenu.Name = "saveMenu";
            resources.ApplyResources(saveMenu, "saveMenu");
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // exitMenu
            // 
            exitMenu.Name = "exitMenu";
            resources.ApplyResources(exitMenu, "exitMenu");
            exitMenu.Click += exitMenu_Click;
            // 
            // FormMain
            // 
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(mainMenu);
            ForeColor = SystemColors.WindowText;
            IsMdiContainer = true;
            MainMenuStrip = mainMenu;
            Name = "FormMain";
            Load += FormMain_Load;
            Shown += FormMain_Shown;
            DragDrop += FormMain_DragDrop;
            DragEnter += FormMain_DragEnter;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem newMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem openMenu;
        private ToolStripMenuItem saveMenu;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitMenu;
    }
}