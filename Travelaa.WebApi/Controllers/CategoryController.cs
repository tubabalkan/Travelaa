using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travelaa.BusinessLayer.Abstract;

namespace Travelaa.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var values= _categoryService.TGetListAll();
            return Ok(values);
        }
    }
}
