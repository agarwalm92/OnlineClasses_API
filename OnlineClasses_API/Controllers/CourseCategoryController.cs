using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineClasses_API.Services;

namespace OnlineClasses_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoryController : ControllerBase
    {
        private readonly ICourseCategoryService _courseCategoryService;
        public CourseCategoryController(ICourseCategoryService _courseCategoryService)
        {
            this._courseCategoryService = _courseCategoryService;
        }

        [HttpGet("GetCourseCategory")]
        public async Task<IActionResult> GetCourseCategory()
        {
            var data  = await _courseCategoryService.GetCourseCategory_Async();
            return Ok(data);
        }

        [HttpGet("GetCourseCategoryById")]
        public async Task<IActionResult> GetCourseCategoryById(int id)
        {
            var data = await _courseCategoryService.GetCourseCategoryById_Async(id);
            if (data == null) 
                return NotFound();

            return Ok(data);
        }
    }
}
