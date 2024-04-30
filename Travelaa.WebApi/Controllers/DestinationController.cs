using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travelaa.BusinessLayer.Abstract;
using Travelaa.EntityLayer.Concrete;

namespace Travelaa.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationController : ControllerBase
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        [HttpGet]
        public IActionResult DestinationList() 
        { 
            var values= _destinationService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateDestination(Destination destination)
        {
            _destinationService.TInsert(destination);
            return Ok("Rota Başarıyla Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteDestination(int id)
        {
            _destinationService.TDelete(id);
            return Ok("Rota Başarıyla Silindi");
        }
        [HttpPut]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.TUpdate(destination);
            return Ok("Güncelleme Yapıldı");
        }
    }
}
