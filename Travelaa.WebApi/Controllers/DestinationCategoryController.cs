using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travelaa.BusinessLayer.Abstract;
using Travelaa.DataAccessLayer.Context;
using Travelaa.WebApi.Models;

namespace Travelaa.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationCategoryController : ControllerBase
    {
        private readonly IDestinationService _destinationService;

        public DestinationCategoryController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            //var values=_appUserService.TUsersListWithWorkLocations();
            TravelaContext context = new TravelaContext();
            var values = context.Destinations.Include(x => x.Category).Select(y => new DestinationCategoryViewModel
            {
                City = y.City,
                Country = y.Country,
                CategoryId = y.CategoryId,
                CategoryName = y.Category.CategoryName,
                ImageUrt = y.ImageUrt,
                CountDay = y.CountDay,
                SubTitle = y.SubTitle,
                Description = y.Description,
                Price = y.Price,
                Date = y.Date,


            }).ToList();
           
            return Ok(values);
        }
    }
}
