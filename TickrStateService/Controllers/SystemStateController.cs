using Microsoft.AspNetCore.Mvc;
using TickrStateService.Entities;

namespace TickrStateService.Controllers
{
    [ApiController]
    [Route("tickr/status")]
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

        [HttpGet("all", Name = "Status")]
        public IEnumerable<SyatemState> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new SyatemState
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Summary = States[Random.Shared.Next(States.Length)]
            })
            .ToArray();
        }
    }
}
