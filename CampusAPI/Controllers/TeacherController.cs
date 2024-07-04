using CampusAPI.Models.HelpersModels;
using CampusAPI.Services;
using CampusAPI.Services.TeacherServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CampusAPI.Controllers
{
    [Route("[controller]")]
    [Authorize]
    public class TeacherController : Controller
    {
        private readonly ITeacherServices _teacherService;

        public TeacherController(ITeacherServices teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("courses/{teacherId}")]
        public IActionResult GetMyCourses(long teacherId)
        {
            var courses = _teacherService.GetCoursesByUserIdAndRoles(teacherId);
            return Ok(courses);
        }

        [HttpGet("active/courses/{teacherId}")]
        public IActionResult GetMyActiveCourses(long teacherId)
        {
            var courses = _teacherService.GetActiveCoursesBySemesterForUser(teacherId);
            return Ok(courses);
        }

    }
}
