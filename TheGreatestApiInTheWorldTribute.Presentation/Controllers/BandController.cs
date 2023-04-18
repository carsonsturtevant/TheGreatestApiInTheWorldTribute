using Microsoft.AspNetCore.Mvc;
using TheGreatestApiInTheWorldTribute.Service.Contracts;

namespace TheGreatestApiInTheWorldTribute.Presentation.Controllers
{
    [Route("api/band")]
    [ApiController]
    public class BandController : ControllerBase
    {
        private readonly IServiceManager _services;

        public BandController(IServiceManager services)
        {
            _services = services;
        }


    }
}
    