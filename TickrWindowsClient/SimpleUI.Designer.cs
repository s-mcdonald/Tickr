namespace TickrWindowsClient
{
    partial class SimpleUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleUI));
            this.txtTest = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.toolBarMain = new System.Windows.Forms.ToolStrip();
            this.toolDebug = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDebug = new System.Windows.Forms.TabPage();
            this.tabPageTest = new System.Windows.Forms.TabPage();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.portfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolBarMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageDebug.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTest
            // 
            this.txtTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTest.Location = new System.Drawing.Point(3, 3);
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(1151, 401);
            this.txtTest.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.toolBarMain);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tabControl);
            this.splitContainer.Size = new System.Drawing.Size(1098, 349);
            this.splitContainer.SplitterDistance = 162;
            this.splitContainer.TabIndex = 2;
            // 
            // toolBarMain
            // 
            this.toolBarMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDebug});
            this.toolBarMain.Location = new System.Drawing.Point(0, 0);
            this.toolBarMain.Name = "toolBarMain";
            this.toolBarMain.Size = new System.Drawing.Size(162, 27);
            this.toolBarMain.TabIndex = 1;
            this.toolBarMain.Text = "toolStrip1";
            // 
            // toolDebug
            // 
            this.toolDebug.Image = ((System.Drawing.Image)(resources.GetObject("toolDebug.Image")));
            this.toolDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDebug.Name = "toolDebug";
            this.toolDebug.Size = new System.Drawing.Size(100, 24);
            this.toolDebug.Text = "Debug All";
            this.toolDebug.Click += new System.EventHandler(this.toolDebug_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageDebug);
            this.tabControl.Controls.Add(this.tabPageTest);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1165, 436);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageDebug
            // 
            this.tabPageDebug.Controls.Add(this.txtTest);
            this.tabPageDebug.Location = new System.Drawing.Point(4, 25);
            this.tabPageDebug.Name = "tabPageDebug";
            this.tabPageDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDebug.Size = new System.Drawing.Size(1157, 407);
            this.tabPageDebug.TabIndex = 0;
            this.tabPageDebug.Text = "Debug";
            this.tabPageDebug.UseVisualStyleBackColor = true;
            // 
            // tabPageTest
            // 
            this.tabPageTest.Location = new System.Drawing.Point(4, 25);
            this.tabPageTest.Name = "tabPageTest";
            this.tabPageTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTest.Size = new System.Drawing.Size(924, 320);
            this.tabPageTest.TabIndex = 1;
            this.tabPageTest.Text = "Test";
            this.tabPageTest.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainer);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1098, 349);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 28);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(1098, 374);
            this.toolStripContainer.TabIndex = 3;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portfolioToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1098, 28);
            this.menuStripMain.TabIndex = 4;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // portfolioToolStripMenuItem
            // 
            this.portfolioToolStripMenuItem.Name = "portfolioToolStripMenuItem";
            this.portfolioToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.portfolioToolStripMenuItem.Text = "Portfolio";
            // 
            // SimpleUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1098, 402);
            this.Controls.Add(this.toolStripContainer);
            this.Controls.Add(this.menuStripMain);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "SimpleUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickr (Windows Client)";
            this.TopMost = true;
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.toolBarMain.ResumeLayout(false);
            this.toolBarMain.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageDebug.ResumeLayout(false);
            this.tabPageDebug.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDebug;
        private System.Windows.Forms.TabPage tabPageTest;
        private System.Windows.Forms.ToolStrip toolBarMain;
        private System.Windows.Forms.ToolStripButton toolDebug;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem portfolioToolStripMenuItem;
    }
}

