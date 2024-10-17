using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travelaa.BusinessLayer.Abstract;

namespace Travelaa.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardIstatistikController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IDestinationService _destinationService;
        private readonly IContactService _contactService;
        private readonly IAdminService _adminService;

        public DashboardIstatistikController(ICategoryService categoryService, IDestinationService destinationService, IContactService contactService, IAdminService adminService)
        {
            _categoryService = categoryService;
            _destinationService = destinationService;
            _contactService = contactService;
            _adminService = adminService;
        }
        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            var value=_categoryService.TCategoryCount();
            return Ok(value);
        }
        [HttpGet("AdminCount")]
        public IActionResult AdminCount()
        {
            var value = _adminService.TAdminCount();
            return Ok(value);
        }
        [HttpGet("ContactCount")]
        public IActionResult ContactCount()
        {
            var value = _contactService.TContactCount();
            return Ok(value);
        }
        [HttpGet("DestinationCount")]
        public IActionResult DestinationCount()
        {
            var value = _destinationService.TDestinationCount();
            return Ok(value);
        }
    }
}
