using System;
using System.Drawing;
using System.Windows.Forms;

namespace TickrWindowsClient.UserControls
{
    public partial class TickerFlowItem : UserControl
    {
        public delegate void TickerClickedEventHandler(object sender, string symbol);
        public event TickerClickedEventHandler TickerClicked;

        private readonly string _symbol;

        public TickerFlowItem(string symbol)
        {
            InitializeComponent();

            _symbol = symbol;

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
            // we will also need the exchange, and asset type in future changes here
            TickerClicked?.Invoke(this, _symbol);
        }
    }
}
