using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
