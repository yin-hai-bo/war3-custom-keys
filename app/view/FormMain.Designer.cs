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
            statusStrip1 = new StatusStrip();
            panel1 = new Panel();
            tabControlMain = new TabControl();
            tabHuman = new TabPage();
            tabOrc = new TabPage();
            tabUndead = new TabPage();
            tabNightElve = new TabPage();
            tabCommon = new TabPage();
            toolStrip1 = new ToolStrip();
            mainMenu.SuspendLayout();
            panel1.SuspendLayout();
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
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.Name = "statusStrip1";
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControlMain);
            panel1.Controls.Add(toolStrip1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
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
            resources.ApplyResources(tabHuman, "tabHuman");
            tabHuman.Name = "tabHuman";
            tabHuman.UseVisualStyleBackColor = true;
            // 
            // tabOrc
            // 
            resources.ApplyResources(tabOrc, "tabOrc");
            tabOrc.Name = "tabOrc";
            tabOrc.UseVisualStyleBackColor = true;
            // 
            // tabUndead
            // 
            resources.ApplyResources(tabUndead, "tabUndead");
            tabUndead.Name = "tabUndead";
            tabUndead.UseVisualStyleBackColor = true;
            // 
            // tabNightElve
            // 
            resources.ApplyResources(tabNightElve, "tabNightElve");
            tabNightElve.Name = "tabNightElve";
            tabNightElve.UseVisualStyleBackColor = true;
            // 
            // tabCommon
            // 
            resources.ApplyResources(tabCommon, "tabCommon");
            tabCommon.Name = "tabCommon";
            tabCommon.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.Name = "toolStrip1";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "FormMain";
            Load += FormMain_Load;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private StatusStrip statusStrip1;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private TabControl tabControlMain;
        private TabPage tabHuman;
        private TabPage tabOrc;
        private TabPage tabUndead;
        private TabPage tabNightElve;
        private TabPage tabCommon;
    }
}