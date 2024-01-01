namespace yhb_war3_custom_keys{
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
            tabControlMain = new TabControl();
            tabHuman = new TabPage();
            tabOrc = new TabPage();
            tabUndead = new TabPage();
            tabNightElve = new TabPage();
            tabCommon = new TabPage();
            mainMenu.SuspendLayout();
            tabControlMain.SuspendLayout();
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
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { newMenu, toolStripSeparator1, openMenu, saveMenu });
            fileMenu.Name = "fileMenu";
            resources.ApplyResources(fileMenu, "fileMenu");
            // 
            // newMenu
            // 
            newMenu.Name = "newMenu";
            resources.ApplyResources(newMenu, "newMenu");
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
            // 
            // saveMenu
            // 
            saveMenu.Name = "saveMenu";
            resources.ApplyResources(saveMenu, "saveMenu");
            // 
            // tabControlMain
            // 
            resources.ApplyResources(tabControlMain, "tabControlMain");
            tabControlMain.Controls.Add(tabHuman);
            tabControlMain.Controls.Add(tabOrc);
            tabControlMain.Controls.Add(tabUndead);
            tabControlMain.Controls.Add(tabNightElve);
            tabControlMain.Controls.Add(tabCommon);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            // 
            // tabHuman
            // 
            tabHuman.BackColor = Color.Black;
            resources.ApplyResources(tabHuman, "tabHuman");
            tabHuman.Name = "tabHuman";
            // 
            // tabOrc
            // 
            tabOrc.BackColor = Color.Black;
            resources.ApplyResources(tabOrc, "tabOrc");
            tabOrc.Name = "tabOrc";
            // 
            // tabUndead
            // 
            tabUndead.BackColor = Color.Black;
            resources.ApplyResources(tabUndead, "tabUndead");
            tabUndead.Name = "tabUndead";
            // 
            // tabNightElve
            // 
            tabNightElve.BackColor = Color.Black;
            resources.ApplyResources(tabNightElve, "tabNightElve");
            tabNightElve.Name = "tabNightElve";
            // 
            // tabCommon
            // 
            tabCommon.BackColor = Color.Black;
            resources.ApplyResources(tabCommon, "tabCommon");
            tabCommon.Name = "tabCommon";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(tabControlMain);
            Controls.Add(mainMenu);
            ForeColor = Color.White;
            MainMenuStrip = mainMenu;
            Name = "FormMain";
            Load += FormMain_Load;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            tabControlMain.ResumeLayout(false);
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
        private TabControl tabControlMain;
        private TabPage tabHuman;
        private TabPage tabOrc;
        private TabPage tabUndead;
        private TabPage tabNightElve;
        private TabPage tabCommon;
    }
}