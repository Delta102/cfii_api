using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines lesson_attempts
/// </summary>
public partial class MdlLessonAttempt
{
    public long Id { get; set; }

    public long Lessonid { get; set; }

    public long Pageid { get; set; }

    public long Userid { get; set; }

    public long Answerid { get; set; }

    public short Retry { get; set; }

    public long Correct { get; set; }

    public string? Useranswer { get; set; }

    public long Timeseen { get; set; }
}
