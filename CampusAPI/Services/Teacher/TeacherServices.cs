using CampusAPI.Models.Moodle;

namespace CampusAPI.Services.TeacherServices
{   
    public interface ITeacherServices { 
        List<MdlCourse> GetCoursesByUserIdAndRoles(int userId);
    }
    public class TeacherServices: ITeacherServices
    {
        public readonly MoodleDBContext _dbContext;

        public TeacherServices(MoodleDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<MdlCourse> GetCoursesByUserIdAndRoles(int userId)
        {
            // Obtener las asignaciones de rol del usuario
            var roleAssignments = _dbContext.MdlRoleAssignments
                .Where(ra => ra.Userid == userId)
                .ToList();

            // Filtrar las asignaciones de rol para obtener los roles 3 (profesor) o 4 (profesor no editable)
            var validRoles = new List<int> { 3, 4 }; // Roles de profesor en Moodle

            var filteredAssignments = roleAssignments
                .Where(ra => validRoles.Contains((int)ra.Roleid))
                .ToList();

            // Obtener los IDs de contexto relacionados con los roles filtrados
            var contextIds = filteredAssignments
                .Select(ra => ra.Contextid)
                .ToList();

            // Obtener los cursos asociados a los IDs de contexto
            var courses = _dbContext.MdlContexts
                .Where(c => contextIds.Contains(c.Id) && c.Contextlevel == 50) // ContextLevel 50 indica cursos en Moodle
                .Join(_dbContext.MdlCourses,
                    c => c.Instanceid,
                    course => course.Id,
                    (c, course) => new MdlCourse
                    {
                        Id = course.Id,
                        Fullname = course.Fullname,
                        Shortname = course.Shortname,
                        // Agregar otros campos relevantes del curso si es necesario
                    })
                .ToList();

            return courses;
        }
    }
}
