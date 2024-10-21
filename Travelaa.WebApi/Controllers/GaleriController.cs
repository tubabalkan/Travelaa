using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travelaa.BusinessLayer.Abstract;

namespace Travelaa.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaleriController : ControllerBase
    {
        private readonly IGaleriService _galeriService;

        public GaleriController(IGaleriService galeriService)
        {
            _galeriService = galeriService;
        }
        [HttpGet]
        public IActionResult GaleriList()
        {
            var values = _galeriService.TGetListAll();
            return Ok(values);
        }
    }
}
