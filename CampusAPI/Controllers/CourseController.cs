using CampusAPI.Services.Course;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CampusAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class CourseController : Controller
    {
        private readonly ICourseServices _courseServices;
        
        public CourseController(ICourseServices courseServices)
        {
            _courseServices = courseServices;
        }

        [HttpGet("{courseId}")]
        public IActionResult GetCourse(long courseId)
        {
            var course = _courseServices.GetCourse(courseId);
            return Ok(course);
        }
    }
}
