using System;
using System.Drawing;
using System.Windows.Forms;

namespace TickrWindowsClient.UserControls
{
    public partial class TickerFlowItem : UserControl
    {
        public TickerFlowItem(string symbol)
        {
            InitializeComponent();

            string filePath = Application.StartupPath + $"/Img/Ticker/{symbol}.png";
            logoImage.ImageLocation = filePath;
            logoImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void logoImage_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void logoImage_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void logoImage_Click(object sender, EventArgs e)
        {
            // open up a tab and show the chart
        }
    }
}
