using CampusAPI.Models.Moodle;

namespace CampusAPI.Services.Course
{
    public interface ICourseServices
    {
        MdlCourse? GetCourse(long courseId);
    }

    public class CourseServices : ICourseServices
    {
        public readonly MoodleDBContext _dbContext;

        public CourseServices(MoodleDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public MdlCourse? GetCourse(long courseId)
        {
            var course = _dbContext.MdlCourses.FirstOrDefault(c => c.Id == courseId);

            if (course == null)
                return null;
            
            return course;
        }

    }
}
