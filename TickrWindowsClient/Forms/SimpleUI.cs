using ScottPlot;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TickrWindowsClient.Api;
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
            var result = assetService.HistoricalPriceData(symbol);

            var OHLCs = new List<OHLC>();

            // Plot https://www.nuget.org/packages/ScottPlot.WinForms/5.0.55
            foreach (var i in result)
            {
                OHLCs.Add(new OHLC(i.Open, i.High, i.Low, i.Close, i.Date, i.TimeSpan));
            }

            chart.Plot.Add.Candlestick(OHLCs);

            chart.Plot.Axes.DateTimeTicksBottom();

            chart.Refresh();
        }
    }
}
