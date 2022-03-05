using KRM3D.Services.Course.Business.Abstract;
using KRM3D.Services.Course.Entities.Concrete.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KRM3D.Services.Course.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _courseService.GetAllAsync();
            return result.Success? Ok(result) : BadRequest(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add(Entities.Concrete.Course course)
        {
            var result =await _courseService.AddAsync(course);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
