using Microsoft.AspNetCore.Mvc;

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
        public IEnumerable<AssetSymbol> Get()
        {
            var requestTime = DateTime.Now.ToShortTimeString();

            Console.WriteLine($"Request pinged at: {requestTime}");

            string[] nasdaqTickers = new string[]
            {
                "TSLA", "PLTR", "AAPL", "MSFT", "GOOGL", "AMZN", "NVDA", "META", "NFLX", "INTC",
                "AMD", "ADBE", "CSCO", "PYPL", "QCOM", "CMCSA", "PEP", "COST", "AVGO", "TXN",
                "MRNA", "SBUX"
            };

            return nasdaqTickers.Select(index => new AssetSymbol
            {
                Symbol = index
            })
            .ToArray();
        }
    }
}
