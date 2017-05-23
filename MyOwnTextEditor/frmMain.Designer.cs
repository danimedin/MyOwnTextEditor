namespace MyOwnTextEditor
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTabbed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCut = new System.Windows.Forms.ToolStripButton();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUndo = new System.Windows.Forms.ToolStripButton();
            this.tsbRedo = new System.Windows.Forms.ToolStripButton();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.tpPlus = new System.Windows.Forms.TabPage();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.msMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            resources.ApplyResources(this.msMain, "msMain");
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.editToolStripMenuItem,
            this.tsmiSeach,
            this.tsmView,
            this.tsmiQuestion});
            this.msMain.Name = "msMain";
            // 
            // tsmiFile
            // 
            resources.ApplyResources(this.tsmiFile, "tsmiFile");
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            // 
            // tsmiNew
            // 
            resources.ApplyResources(this.tsmiNew, "tsmiNew");
            this.tsmiNew.Image = global::MyOwnTextEditor.icons._new;
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiOpen
            // 
            resources.ApplyResources(this.tsmiOpen, "tsmiOpen");
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            resources.ApplyResources(this.tsmiSave, "tsmiSave");
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiSaveAs
            // 
            resources.ApplyResources(this.tsmiSaveAs, "tsmiSaveAs");
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // tsmiExit
            // 
            resources.ApplyResources(this.tsmiExit, "tsmiExit");
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // editToolStripMenuItem
            // 
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.tsmiDo,
            this.toolStripSeparator1,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            // 
            // tsmiUndo
            // 
            resources.ApplyResources(this.tsmiUndo, "tsmiUndo");
            this.tsmiUndo.Image = global::MyOwnTextEditor.icons.undo;
            this.tsmiUndo.Name = "tsmiUndo";
            // 
            // tsmiDo
            // 
            resources.ApplyResources(this.tsmiDo, "tsmiDo");
            this.tsmiDo.Image = global::MyOwnTextEditor.icons.redo;
            this.tsmiDo.Name = "tsmiDo";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // tsmiCut
            // 
            resources.ApplyResources(this.tsmiCut, "tsmiCut");
            this.tsmiCut.Image = global::MyOwnTextEditor.icons.Cut;
            this.tsmiCut.Name = "tsmiCut";
            // 
            // tsmiCopy
            // 
            resources.ApplyResources(this.tsmiCopy, "tsmiCopy");
            this.tsmiCopy.Image = global::MyOwnTextEditor.icons.copy;
            this.tsmiCopy.Name = "tsmiCopy";
            // 
            // tsmiPaste
            // 
            resources.ApplyResources(this.tsmiPaste, "tsmiPaste");
            this.tsmiPaste.Image = global::MyOwnTextEditor.icons.paste;
            this.tsmiPaste.Name = "tsmiPaste";
            // 
            // tsmiSeach
            // 
            resources.ApplyResources(this.tsmiSeach, "tsmiSeach");
            this.tsmiSeach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFind,
            this.tsmiReplace});
            this.tsmiSeach.Name = "tsmiSeach";
            // 
            // tsmiFind
            // 
            resources.ApplyResources(this.tsmiFind, "tsmiFind");
            this.tsmiFind.Image = global::MyOwnTextEditor.icons.find;
            this.tsmiFind.Name = "tsmiFind";
            this.tsmiFind.Click += new System.EventHandler(this.tsmiFind_Click);
            // 
            // tsmiReplace
            // 
            resources.ApplyResources(this.tsmiReplace, "tsmiReplace");
            this.tsmiReplace.Name = "tsmiReplace";
            // 
            // tsmView
            // 
            resources.ApplyResources(this.tsmView, "tsmView");
            this.tsmView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTabbed,
            this.tsmWindow});
            this.tsmView.Name = "tsmView";
            // 
            // tsmTabbed
            // 
            resources.ApplyResources(this.tsmTabbed, "tsmTabbed");
            this.tsmTabbed.Checked = true;
            this.tsmTabbed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmTabbed.Name = "tsmTabbed";
            this.tsmTabbed.Click += new System.EventHandler(this.tsmTabbed_Click);
            // 
            // tsmWindow
            // 
            resources.ApplyResources(this.tsmWindow, "tsmWindow");
            this.tsmWindow.Name = "tsmWindow";
            this.tsmWindow.Click += new System.EventHandler(this.tsmWindow_Click);
            // 
            // tsmiQuestion
            // 
            resources.ApplyResources(this.tsmiQuestion, "tsmiQuestion");
            this.tsmiQuestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiQuestion.Name = "tsmiQuestion";
            // 
            // tsmiAbout
            // 
            resources.ApplyResources(this.tsmiAbout, "tsmiAbout");
            this.tsmiAbout.Name = "tsmiAbout";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbOpen,
            this.tsbSave,
            this.toolStripSeparator2,
            this.tsbCut,
            this.tsbCopy,
            this.tsbPaste,
            this.toolStripSeparator3,
            this.tsbUndo,
            this.tsbRedo});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // tsbNew
            // 
            resources.ApplyResources(this.tsbNew, "tsbNew");
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = global::MyOwnTextEditor.icons._new;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbOpen
            // 
            resources.ApplyResources(this.tsbOpen, "tsbOpen");
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = global::MyOwnTextEditor.icons.open;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbSave
            // 
            resources.ApplyResources(this.tsbSave, "tsbSave");
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::MyOwnTextEditor.icons.save;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // tsbCut
            // 
            resources.ApplyResources(this.tsbCut, "tsbCut");
            this.tsbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCut.Image = global::MyOwnTextEditor.icons.Cut;
            this.tsbCut.Name = "tsbCut";
            // 
            // tsbCopy
            // 
            resources.ApplyResources(this.tsbCopy, "tsbCopy");
            this.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopy.Image = global::MyOwnTextEditor.icons.copy;
            this.tsbCopy.Name = "tsbCopy";
            // 
            // tsbPaste
            // 
            resources.ApplyResources(this.tsbPaste, "tsbPaste");
            this.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPaste.Image = global::MyOwnTextEditor.icons.paste;
            this.tsbPaste.Name = "tsbPaste";
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // tsbUndo
            // 
            resources.ApplyResources(this.tsbUndo, "tsbUndo");
            this.tsbUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUndo.Image = global::MyOwnTextEditor.icons.undo;
            this.tsbUndo.Name = "tsbUndo";
            // 
            // tsbRedo
            // 
            resources.ApplyResources(this.tsbRedo, "tsbRedo");
            this.tsbRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRedo.Image = global::MyOwnTextEditor.icons.redo;
            this.tsbRedo.Name = "tsbRedo";
            // 
            // tcMain
            // 
            resources.ApplyResources(this.tcMain, "tcMain");
            this.tcMain.Controls.Add(this.tp1);
            this.tcMain.Controls.Add(this.tpPlus);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_selectedIndexChanged);
            // 
            // tp1
            // 
            resources.ApplyResources(this.tp1, "tp1");
            this.tp1.Name = "tp1";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // tpPlus
            // 
            resources.ApplyResources(this.tpPlus, "tpPlus");
            this.tpPlus.Name = "tpPlus";
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.myOwnForm_Closing);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
        private System.Windows.Forms.ToolStripMenuItem tsmiDo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiSeach;
        private System.Windows.Forms.ToolStripMenuItem tsmiFind;
        private System.Windows.Forms.ToolStripMenuItem tsmiReplace;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuestion;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbCut;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripButton tsbPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbUndo;
        private System.Windows.Forms.ToolStripButton tsbRedo;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.TabPage tpPlus;
        private System.Windows.Forms.ToolStripMenuItem tsmView;
        private System.Windows.Forms.ToolStripMenuItem tsmWindow;
        public System.Windows.Forms.ToolStripMenuItem tsmTabbed;
    }
}

