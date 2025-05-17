using System;
using System.Windows.Forms;
using TickrWindowsClient.Api;
using TickrWindowsClient.UserControls;

namespace TickrWindowsClient
{
    public partial class SimpleUI : Form
    {
        HealthCheckService healthCheck;

        public SimpleUI()
        {
            InitializeComponent();
            healthCheck = new HealthCheckService();
        }

        private void menuItemHealthCheck_Click(object sender, EventArgs e)
        {
            var result = healthCheck.FetchAll();


            txtTest.Text = result;
        }

        private void menuItemSwitchUS_Click(object sender, EventArgs e)
        {
            flowAssets.SuspendLayout();

            // Get a list of assets from the server
            string[] assets = { "TSLA", "PLTR" };

            //var result = tickerService.GetAllAssets("NASDAQ");

            // Iterate and add items
            foreach (var i in assets)
            {
                TickerFlowItem item = new TickerFlowItem(i);
                flowAssets.Controls.Add(item);

                item.Width = 70; 
                item.Height = 70; 
            }

            flowAssets.ResumeLayout();
        }
    }
}
