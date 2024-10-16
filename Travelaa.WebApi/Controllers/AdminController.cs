using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travelaa.BusinessLayer.Abstract;
using Travelaa.EntityLayer.Concrete;

namespace Travelaa.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpGet]
        public IActionResult AdminList()
        {
            var values = _adminService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAdmin(Admin admin)
        {
            _adminService.TInsert(admin);
            return Ok("Admin Ekleme İşlemi Başarıyla Tamamalandı");
        }
        [HttpDelete]
        public IActionResult DeleteAdmin(int id)
        {
            _adminService.TDelete(id);
            return Ok("Admin Silme İşlemi Başarıyla Tamamalandı");
        }
        [HttpGet("GetAdmin")]
        public IActionResult GetAdmin(int id)
        {
            var value = _adminService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateAdmin(Admin admin)
        {
            _adminService.TUpdate(admin);
            return Ok("Admin Güncelleme İşlemi Başarıyla Tamamalandı");
        }
    }
}
