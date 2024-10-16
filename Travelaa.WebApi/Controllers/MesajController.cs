using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travelaa.BusinessLayer.Abstract;

namespace Travelaa.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesajController : ControllerBase
    {
        private readonly IContactService _contactService;

        public MesajController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _contactService.TGetListAll();
            return Ok(values);
        }
    }
}
