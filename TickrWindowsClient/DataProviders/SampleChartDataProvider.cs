using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickrWindowsClient.DataProviders
{
    internal class SampleChartDataProvider
    {
        public SampleChartDataProvider() { }

        public float[] getXData()
        {
            return new float[] { 1, 2, 3, 4, 5 };
        }

        public float[] getYData()
        {
            return new float[] { 1, 4, 9, 16, 25 };
        }
    }
}
