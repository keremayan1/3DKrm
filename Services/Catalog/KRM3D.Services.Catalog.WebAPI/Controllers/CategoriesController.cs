using KRM3D.Services.Catalog.Business.Abstract;
using KRM3D.Services.Catalog.Entities.Concrete.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KRM3D.Services.Catalog.WebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categoryService.GetAllAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid/{categoryId}")]
        public async Task<IActionResult> GetById(string categoryId)
        {
            var result = await _categoryService.GetByIdAsync(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(CategoryDto category)
        {
            var result = await _categoryService.CreateAsync(category);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string categoryId)
        {
            var result =await _categoryService.DeleteAsync(categoryId);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
