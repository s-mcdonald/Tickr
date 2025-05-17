using System;
using System.Windows.Forms;
using TickrWindowsClient.Api;

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
    }
}
