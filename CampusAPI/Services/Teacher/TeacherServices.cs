using CampusAPI.Models.Icacit;
using CampusAPI.Models.Moodle;
using System.Linq;

namespace CampusAPI.Services.TeacherServices
{   
    public interface ITeacherServices { 
        List<MdlCourse> GetCoursesByUserIdAndRoles(long userId);
        List<MdlCourse> GetActiveCoursesBySemesterForUser(long userId);
    }
    public class TeacherServices: ITeacherServices
    {
        private readonly MoodleDBContext _dbContext;
        private readonly IcacitDBContext _icacitDbContext;

        public TeacherServices(MoodleDBContext dbContext, IcacitDBContext icacitDBContext)
        {
            _dbContext = dbContext;
            _icacitDbContext = icacitDBContext;
        }


        public List<MdlCourse> GetCoursesByUserIdAndRoles(long userId)
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

        public List<MdlCourse> GetActiveCoursesBySemesterForUser(long userId)
        {
            // Obtener el ID máximo del semestre desde Icacit
            var maxSemesterId = _icacitDbContext.Semestres.Max(s => s.Id);

            // Consultar los cursos activos del usuario para el semestre máximo en Icacit
            var moodleCourseIds = _icacitDbContext.Aulas
                                        .Where(a => a.Semestreid == maxSemesterId)
                                        .Select(a => a.Moodlecourseid)
                                        .ToList();

            // Consultar los cursos activos del usuario en Moodle
            var activeCourses = (from user in _dbContext.MdlUsers
                                 join enrolment in _dbContext.MdlUserEnrolments on user.Id equals enrolment.Userid
                                 join enrol in _dbContext.MdlEnrols on enrolment.Enrolid equals enrol.Id
                                 join course in _dbContext.MdlCourses on enrol.Courseid equals course.Id
                                 where user.Id == userId && moodleCourseIds.Contains((int)course.Id)
                                 select new MdlCourse
                                 {
                                     Id = course.Id,
                                     Fullname = course.Fullname,
                                     Shortname = course.Shortname,
                                 }).ToList();

            return activeCourses;
        }
    }
}
