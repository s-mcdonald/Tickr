using System;
using System.Windows.Forms;
using TickrWindowsClient.Api;
using TickrWindowsClient.DataProviders;
using TickrWindowsClient.UserControls;

namespace TickrWindowsClient
{
    public partial class SimpleUI : Form
    {
        private readonly AssetService assetService;
        private readonly HealthCheckService healthCheck;

        public SimpleUI()
        {
            InitializeComponent();
            assetService = new AssetService();
            healthCheck = new HealthCheckService();

            var sampleDataProvider = new SampleChartDataProvider();
            chart.Plot.Add.Scatter(
                sampleDataProvider.getXData(),
                sampleDataProvider.getYData()
            );

            chart.Refresh();
        }

        private void menuItemHealthCheck_Click(object sender, EventArgs e)
        {
            txtTest.Text = healthCheck.FetchAll();
        }

        private void menuItemSwitchUS_Click(object sender, EventArgs e)
        {
            flowAssets.SuspendLayout();

            var assets = assetService.FetchAll();

            foreach (var i in assets)
            {
                TickerFlowItem item = new TickerFlowItem(i);
                item.TickerClicked += TickerItem_TickerClicked;

                flowAssets.Controls.Add(item);

                item.Width = 70; 
                item.Height = 70;
            }

            flowAssets.ResumeLayout();
        }

        private void TickerItem_TickerClicked(object sender, string symbol)
        {
            MessageBox.Show($"You clicked on ticker: {symbol}");
        }
    }
}
