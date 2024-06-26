using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines lesson_grades
/// </summary>
public partial class MdlLessonGrade
{
    public long Id { get; set; }

    public long Lessonid { get; set; }

    public long Userid { get; set; }

    public double Grade { get; set; }

    public short Late { get; set; }

    public long Completed { get; set; }
}
