using CampusAPI.Models.HelpersModels;
using CampusAPI.Services;
using CampusAPI.Services.TeacherServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CampusAPI.Controllers
{
    [Authorize]
    public class TeacherController : Controller
    {
        private readonly ITeacherServices _teacherService;

        public TeacherController(ITeacherServices teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("courses/{teacherId}")]
        public IActionResult GetMyCourses(int teacherId)
        {
            var courses = _teacherService.GetCoursesByUserIdAndRoles(teacherId);
            return Ok(courses);
        }

    }
}
