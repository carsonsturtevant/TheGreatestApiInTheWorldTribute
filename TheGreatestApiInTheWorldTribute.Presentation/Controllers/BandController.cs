using Microsoft.AspNetCore.Mvc;
using TheGreatestApiInTheWorldTribute.Service.Contracts;

namespace TheGreatestApiInTheWorldTribute.Presentation.Controllers
{
    [Route("api/band")]
    [ApiController]
    public class BandController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public BandController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult GetAllBands()
        {
            try
            {
                return Ok(_serviceManager.BandService.GetAllBands(trackChanges: false));
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
    