using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineClasses_API.Data.Entities;

namespace OnlineClasses_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly OnlineCourseDbContext _dbContext;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, OnlineCourseDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            var courses = _dbContext.Courses.ToList();
            return Ok(courses);
        }
    }
}
