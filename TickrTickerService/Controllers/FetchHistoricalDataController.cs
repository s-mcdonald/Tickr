using Microsoft.AspNetCore.Mvc;
using TickrTickerService.Entities;

namespace TickrTickerService.Controllers
{
    [ApiController]
    [Route("tickr")]
    public class FetchHistoricalDataController : ControllerBase
    {
        private readonly ILogger<FetchHistoricalDataController> _logger;

        public FetchHistoricalDataController(ILogger<FetchHistoricalDataController> logger)
        {
            _logger = logger;
        }

        // Route: tickr/assets/history/{symbol}
        [HttpGet("assets/history/{symbol}", Name = "ListHistoricalPriceData")]
        public ActionResult<IEnumerable<AssetHistoricalPriceData>> GetHistoricalData(string symbol)
        {
            var requestTime = DateTime.Now.ToShortTimeString();

            Console.WriteLine($"Request pinged at: {requestTime}");

            _logger.LogInformation($"Historical data requested for '{symbol}' at {requestTime}");

            // Mock response - TODO: replace with actual DB/service call
            var mockData = new List<AssetHistoricalPriceData>
            {
                new AssetHistoricalPriceData
                {
                    Symbol = symbol,
                    Date = DateTime.UtcNow.AddDays(-5),
                    Open = 100.75f,
                    High = 102.10f,
                    Low = 99.80f,
                    Close = 101.23f
                },
                new AssetHistoricalPriceData
                {
                    Symbol = symbol,
                    Date = DateTime.UtcNow.AddDays(-4),
                    Open = 101.50f,
                    High = 103.00f,
                    Low = 100.90f,
                    Close = 102.45f
                },
                new AssetHistoricalPriceData
                {
                    Symbol = symbol,
                    Date = DateTime.UtcNow.AddDays(-3),
                    Open = 102.60f,
                    High = 103.40f,
                    Low = 99.95f,
                    Close = 100.85f
                },
                new AssetHistoricalPriceData
                {
                    Symbol = symbol,
                    Date = DateTime.UtcNow.AddDays(-2),
                    Open = 100.90f,
                    High = 101.20f,
                    Low = 98.75f,
                    Close = 99.55f
                },
                new AssetHistoricalPriceData
                {
                    Symbol = symbol,
                    Date = DateTime.UtcNow.AddDays(-1),
                    Open = 99.80f,
                    High = 104.25f,
                    Low = 99.50f,
                    Close = 103.00f
                }
            };


            return Ok(mockData);
        }
    }
}
