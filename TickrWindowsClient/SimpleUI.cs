using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace TickrWindowsClient
{
    public partial class SimpleUI : Form
    {
        public SimpleUI()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            

            try
            {
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls;

                string apiUrl = "http://localhost:5112/tickr/status/all"; 

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
                request.Method = "GET";
                request.ContentType = "application/json";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string jsonResponse = reader.ReadToEnd();
                    txtTest.Text = jsonResponse;
                }
            }
            catch (Exception ex)
            {
                txtTest.Text = ex.Message;
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
