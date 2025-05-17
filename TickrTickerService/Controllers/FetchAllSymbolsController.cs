using Microsoft.AspNetCore.Mvc;
using TickrTickerService.Entities;

namespace TickrTickerService.Controllers
{
    [ApiController]
    [Route("tickr")]
    public class FetchAllSymbolsController : ControllerBase
    {
        private readonly ILogger<FetchAllSymbolsController> _logger;

        public FetchAllSymbolsController(ILogger<FetchAllSymbolsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("assets", Name = "ListAllAssets")]
        public IEnumerable<Asset> Get()
        {
            var requestTime = DateTime.Now.ToShortTimeString();

            Console.WriteLine($"Request pinged at: {requestTime}");

            // TODO: Fetch this data from external source or DB service
            // for now just hard coded for initial development.
            List<(string Symbol, string Exchange)> nasdaqAssets = new List<(string, string)>
            {
                ("TSLA", "NASDAQ"),
                ("PLTR", "NASDAQ"),
                ("AAPL", "NASDAQ"),
                ("MSFT", "NASDAQ"),
                ("GOOGL", "NASDAQ"),
                ("AMZN", "NASDAQ"),
                ("NVDA", "NASDAQ"),
                ("META", "NASDAQ"),
                ("NFLX", "NASDAQ"),
                ("INTC", "NASDAQ"),
                ("AMD", "NASDAQ"),
                ("ADBE", "NASDAQ"),
                ("CSCO", "NASDAQ"),
                ("PYPL", "NASDAQ"),
                ("QCOM", "NASDAQ"),
                ("CMCSA", "NASDAQ"),
                ("PEP", "NASDAQ"),
                ("COST", "NASDAQ"),
                ("AVGO", "NASDAQ"),
                ("TXN", "NASDAQ"),
                ("MRNA", "NASDAQ"),
                ("SBUX", "NASDAQ"),
            };

            List<(string Symbol, string Exchange)> nyseAssets = new List<(string,string)>
            {
                ("BRK.A", "NYSE"),
                ("JNJ", "NYSE"),
                ("V", "NYSE"),
                ("PG", "NYSE"),
                ("DIS", "NYSE"),
                ("WMT", "NYSE"),
            };

            // Invalid valuies
            List<(string Symbol, string Exchange)> otherAssets = new List<(string, string)>
            {
                ("ABCD", ""),
                ("XYZ", ""),
            };


            var x = nasdaqAssets
                .Select(item => new Asset
                {
                    Symbol = item.Symbol,
                    Exchange = item.Exchange,
                    AssetType = Enums.AssetType.Equities
                })
                .Concat(nyseAssets
                    .Select(item => new Asset
                    {
                        Symbol = item.Symbol,
                        Exchange = item.Exchange,
                        AssetType = Enums.AssetType.Equities
                    }))
                .Concat(otherAssets
                    .Select(item => new Asset
                    {
                        Symbol = item.Symbol,
                        Exchange = item.Exchange,
                        AssetType = Enums.AssetType.Equities
                    }))
                .ToArray();

            // only return valid assets
            return x.Where(x => x.Valid() == true);
        }
    }
}
