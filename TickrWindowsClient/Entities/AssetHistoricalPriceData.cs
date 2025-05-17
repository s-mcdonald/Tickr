using System;

namespace TickrWindowsClient.Entities
{
    public class AssetHistoricalPriceData
    {
        public DateTime Date { get; set; }

        public TimeSpan TimeSpan
        {
            get { return TimeSpan.FromSeconds(5); }
        }

        public string Symbol { get; set; }

        public float Open { get; set; }

        public float High { get; set; }

        public float Low { get; set; }

        public float Close { get; set; }
    }
}
