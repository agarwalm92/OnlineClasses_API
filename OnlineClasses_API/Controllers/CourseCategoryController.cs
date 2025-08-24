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

        [HttpGet]
        public async Task<IActionResult> GetCourseCategory()
        {
            var data  = await _courseCategoryService.GetCourseCategory_Async();
            return Ok(data);
        }

        //[HttpGet]
        //public async Task<IActionResult> GetCourseCategoryById(int id)
        //{
        //    var data = await _courseCategoryService.GetCourseCategoryById_Async(id);
        //    return Ok(data);
        //}
    }
}
