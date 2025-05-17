using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

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
                // convert to array
                return symbols;
            }

            Console.WriteLine(ApiEndPoint.ListAllAssets);


            return new string[] { "", "" };

            throw new Exception(response.ResponseMessage);
        }
    }
}
