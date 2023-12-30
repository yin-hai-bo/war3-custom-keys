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
            toolStrip1 = new ToolStrip();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            GroupTreeView = new TreeView();
            keyDefineListView = new ListView();
            mainMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(toolStrip1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.Name = "toolStrip1";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // panel3
            // 
            panel3.Controls.Add(GroupTreeView);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // panel4
            // 
            panel4.Controls.Add(keyDefineListView);
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // GroupTreeView
            // 
            resources.ApplyResources(GroupTreeView, "GroupTreeView");
            GroupTreeView.Name = "GroupTreeView";
            // 
            // keyDefineListView
            // 
            resources.ApplyResources(keyDefineListView, "keyDefineListView");
            keyDefineListView.Name = "keyDefineListView";
            keyDefineListView.UseCompatibleStateImageBehavior = false;
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
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
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
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private ToolStrip toolStrip1;
        private ListView keyDefineListView;
        private TreeView GroupTreeView;
    }
}