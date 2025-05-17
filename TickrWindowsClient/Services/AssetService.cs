using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using TickrWindowsClient.Entities;

namespace TickrWindowsClient.Api
{
    public class Ticker
    {
        public string Symbol { get; set; }
    }

    internal class AssetService
    {
        public string[] FetchAll()
        {
            var response = ApiRequest.Get(ApiEndPoint.ListAllAssets);
            if (response.RequestStatus.Success)
            {
                List<Ticker> tickers = JsonConvert.DeserializeObject<List<Ticker>>(response.ResponseMessage);
                string[] symbols = tickers.Select(t => t.Symbol).ToArray();
                return symbols;
            }

            Console.WriteLine(ApiEndPoint.ListAllAssets);

            return new string[] { "", "" };
        }

        public List<AssetHistoricalPriceData> HistoricalPriceData(string asset)
        {
            var response = ApiRequest.Get(ApiEndPoint.ListHistoricalData.Replace("[symbol]", asset));
            if (response.RequestStatus.Success)
            {
                List<AssetHistoricalPriceData> tickers = JsonConvert.DeserializeObject<List<AssetHistoricalPriceData>>(response.ResponseMessage);
                return tickers;
            }

            Console.WriteLine(ApiEndPoint.ListHistoricalData);

            return new List<AssetHistoricalPriceData> { };
        }
    }
}
