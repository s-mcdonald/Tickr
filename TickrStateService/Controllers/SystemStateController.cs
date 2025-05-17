using Microsoft.AspNetCore.Mvc;
using TickrStateService.Entities;
using TickrStateService.Services;

namespace TickrStateService.Controllers
{
    [ApiController]
    [Route("tickr")]
    public class SystemStateController : ControllerBase
    {
        private static readonly string[] States = new[]
        {
            "Inactive", "Stalled", "Active",
        };

        private readonly ILogger<SystemStateController> _logger;

        public SystemStateController(ILogger<SystemStateController> logger)
        {
            _logger = logger;
        }

        // We will need to return this to IEnumerable but for now we just need to fetch the
        // single State of assets.
        [HttpGet("status", Name = "Status")]
        public async Task<SyatemState> GetAsync()
        {
            Console.WriteLine($"Request pinged at: {DateTime.Now.ToShortTimeString()}");

            // refactor this to a repository class or a configuration
            string StatusURI = "http://localhost:5054/tickr/assets/status";

            SyatemState syatemState = await ApiRequest.GetAsync<SyatemState>(StatusURI);

            return syatemState;
        }
    }
}
