using Microsoft.AspNetCore.Mvc;
using TickrTickerService.Entities;

namespace TickrTickerService.Controllers
{
    [ApiController]
    [Route("tickr/assets")]
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

        [HttpGet("status", Name = "Status")]
        public SyatemState Get()
        {
            return new SyatemState
            {
                Date = DateTime.Now.Date,
                State = States[2],
            };
        }
    }
}
