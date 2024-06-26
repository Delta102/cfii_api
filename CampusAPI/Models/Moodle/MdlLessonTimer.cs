using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// lesson timer for each lesson
/// </summary>
public partial class MdlLessonTimer
{
    public long Id { get; set; }

    public long Lessonid { get; set; }

    public long Userid { get; set; }

    public long Starttime { get; set; }

    public long Lessontime { get; set; }

    public bool? Completed { get; set; }

    public long Timemodifiedoffline { get; set; }
}
