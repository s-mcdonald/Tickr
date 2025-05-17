namespace TickrWindowsClient.UserControls
{
    partial class TickerFlowItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TickerFlowItem));
            this.logoImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // logoImage
            // 
            this.logoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoImage.Image = ((System.Drawing.Image)(resources.GetObject("logoImage.Image")));
            this.logoImage.Location = new System.Drawing.Point(2, 2);
            this.logoImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoImage.Name = "logoImage";
            this.logoImage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoImage.Size = new System.Drawing.Size(44, 48);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImage.TabIndex = 0;
            this.logoImage.TabStop = false;
            this.logoImage.Click += new System.EventHandler(this.logoImage_Click);
            this.logoImage.MouseLeave += new System.EventHandler(this.logoImage_MouseLeave);
            this.logoImage.MouseHover += new System.EventHandler(this.logoImage_MouseHover);
            // 
            // TickerFlowItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.logoImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TickerFlowItem";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Size = new System.Drawing.Size(48, 52);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoImage;
    }
}
