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
            this.txtTest = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tabControlSideBar = new System.Windows.Forms.TabControl();
            this.tabPageAssets = new System.Windows.Forms.TabPage();
            this.flowAssets = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageWatchlist = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDebug = new System.Windows.Forms.TabPage();
            this.tabPageTest = new System.Windows.Forms.TabPage();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.menuItemSwitchAU = new System.Windows.Forms.ToolStripButton();
            this.menuItemSwitchUS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemHealthCheck = new System.Windows.Forms.ToolStripButton();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.portfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.chart = new ScottPlot.WinForms.FormsPlot();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tabControlSideBar.SuspendLayout();
            this.tabPageAssets.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageDebug.SuspendLayout();
            this.tabPageTest.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.toolStripMain.SuspendLayout();
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
            this.txtTest.Size = new System.Drawing.Size(891, 361);
            this.txtTest.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tabControlSideBar);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tabControl);
            this.splitContainer.Size = new System.Drawing.Size(1120, 396);
            this.splitContainer.SplitterDistance = 207;
            this.splitContainer.SplitterWidth = 8;
            this.splitContainer.TabIndex = 2;
            // 
            // tabControlSideBar
            // 
            this.tabControlSideBar.Controls.Add(this.tabPageAssets);
            this.tabControlSideBar.Controls.Add(this.tabPageWatchlist);
            this.tabControlSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSideBar.Location = new System.Drawing.Point(0, 0);
            this.tabControlSideBar.Name = "tabControlSideBar";
            this.tabControlSideBar.SelectedIndex = 0;
            this.tabControlSideBar.Size = new System.Drawing.Size(207, 396);
            this.tabControlSideBar.TabIndex = 0;
            // 
            // tabPageAssets
            // 
            this.tabPageAssets.Controls.Add(this.flowAssets);
            this.tabPageAssets.Location = new System.Drawing.Point(4, 25);
            this.tabPageAssets.Name = "tabPageAssets";
            this.tabPageAssets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAssets.Size = new System.Drawing.Size(199, 367);
            this.tabPageAssets.TabIndex = 0;
            this.tabPageAssets.Text = "Assets";
            this.tabPageAssets.UseVisualStyleBackColor = true;
            // 
            // flowAssets
            // 
            this.flowAssets.AutoScroll = true;
            this.flowAssets.BackColor = System.Drawing.Color.Black;
            this.flowAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowAssets.Location = new System.Drawing.Point(3, 3);
            this.flowAssets.Name = "flowAssets";
            this.flowAssets.Padding = new System.Windows.Forms.Padding(3);
            this.flowAssets.Size = new System.Drawing.Size(193, 361);
            this.flowAssets.TabIndex = 0;
            // 
            // tabPageWatchlist
            // 
            this.tabPageWatchlist.Location = new System.Drawing.Point(4, 25);
            this.tabPageWatchlist.Name = "tabPageWatchlist";
            this.tabPageWatchlist.Size = new System.Drawing.Size(199, 367);
            this.tabPageWatchlist.TabIndex = 1;
            this.tabPageWatchlist.Text = "Watchlist";
            this.tabPageWatchlist.UseVisualStyleBackColor = true;
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
            this.tabControl.Size = new System.Drawing.Size(905, 396);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageDebug
            // 
            this.tabPageDebug.Controls.Add(this.txtTest);
            this.tabPageDebug.Location = new System.Drawing.Point(4, 25);
            this.tabPageDebug.Name = "tabPageDebug";
            this.tabPageDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDebug.Size = new System.Drawing.Size(897, 367);
            this.tabPageDebug.TabIndex = 0;
            this.tabPageDebug.Text = "Debug";
            this.tabPageDebug.UseVisualStyleBackColor = true;
            // 
            // tabPageTest
            // 
            this.tabPageTest.Controls.Add(this.chart);
            this.tabPageTest.Location = new System.Drawing.Point(4, 25);
            this.tabPageTest.Name = "tabPageTest";
            this.tabPageTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTest.Size = new System.Drawing.Size(897, 367);
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
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1120, 396);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 28);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(1120, 423);
            this.toolStripContainer.TabIndex = 3;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripMain);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSwitchAU,
            this.menuItemSwitchUS,
            this.toolStripSeparator2,
            this.menuItemHealthCheck});
            this.toolStripMain.Location = new System.Drawing.Point(4, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(106, 27);
            this.toolStripMain.TabIndex = 0;
            // 
            // menuItemSwitchAU
            // 
            this.menuItemSwitchAU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuItemSwitchAU.Image = global::TickrWindowsClient.Properties.Resources.flag_aus;
            this.menuItemSwitchAU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuItemSwitchAU.Name = "menuItemSwitchAU";
            this.menuItemSwitchAU.Size = new System.Drawing.Size(29, 24);
            this.menuItemSwitchAU.Text = "toolStripButton2";
            this.menuItemSwitchAU.ToolTipText = "ASX";
            // 
            // menuItemSwitchUS
            // 
            this.menuItemSwitchUS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuItemSwitchUS.Image = global::TickrWindowsClient.Properties.Resources.flag_usa;
            this.menuItemSwitchUS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuItemSwitchUS.Name = "menuItemSwitchUS";
            this.menuItemSwitchUS.Size = new System.Drawing.Size(29, 24);
            this.menuItemSwitchUS.Text = "toolStripButton3";
            this.menuItemSwitchUS.ToolTipText = "NASDAQ and NYSE";
            this.menuItemSwitchUS.Click += new System.EventHandler(this.menuItemSwitchUS_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // menuItemHealthCheck
            // 
            this.menuItemHealthCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuItemHealthCheck.Image = global::TickrWindowsClient.Properties.Resources.status_health;
            this.menuItemHealthCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuItemHealthCheck.Name = "menuItemHealthCheck";
            this.menuItemHealthCheck.Size = new System.Drawing.Size(29, 24);
            this.menuItemHealthCheck.Text = "toolStripButton1";
            this.menuItemHealthCheck.Click += new System.EventHandler(this.menuItemHealthCheck_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portfolioToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1120, 28);
            this.menuStripMain.TabIndex = 4;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // portfolioToolStripMenuItem
            // 
            this.portfolioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen,
            this.toolStripSeparator1,
            this.menuItemExit});
            this.portfolioToolStripMenuItem.Name = "portfolioToolStripMenuItem";
            this.portfolioToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.portfolioToolStripMenuItem.Text = "Portfolio";
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(128, 26);
            this.menuItemOpen.Text = "&Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(128, 26);
            this.menuItemExit.Text = "E&xit";
            // 
            // chart
            // 
            this.chart.DisplayScale = 0F;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(4, 4);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1114, 451);
            this.chart.TabIndex = 0;
            // 
            // SimpleUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1120, 451);
            this.Controls.Add(this.toolStripContainer);
            this.Controls.Add(this.menuStripMain);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "SimpleUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickr (Windows Client)";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tabControlSideBar.ResumeLayout(false);
            this.tabPageAssets.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageDebug.ResumeLayout(false);
            this.tabPageDebug.PerformLayout();
            this.tabPageTest.ResumeLayout(false);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem portfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton menuItemSwitchAU;
        private System.Windows.Forms.ToolStripButton menuItemSwitchUS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton menuItemHealthCheck;
        private System.Windows.Forms.TabControl tabControlSideBar;
        private System.Windows.Forms.TabPage tabPageAssets;
        private System.Windows.Forms.TabPage tabPageWatchlist;
        private System.Windows.Forms.FlowLayoutPanel flowAssets;
        private ScottPlot.WinForms.FormsPlot chart;
    }
}

