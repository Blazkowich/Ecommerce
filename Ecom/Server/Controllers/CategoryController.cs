using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.Server.Controllers
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
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategories()
        {
            var categories = await _categoryService.GetCategoriesAsync();
            return Ok(categories);
        }

        [HttpGet("GetCategoryByUrlId/{categoryUrl}")]
        public async Task<ActionResult> GetCategoryByUrlId(string categoryUrl)
        {
            var categoryId = await _categoryService.GetCategoryByUrlId(categoryUrl);

            if (categoryId != 0)
            {
                return Ok(categoryId);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
