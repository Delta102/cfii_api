using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// The overrides to lesson settings.
/// </summary>
public partial class MdlLessonOverride
{
    public long Id { get; set; }

    public long Lessonid { get; set; }

    public long? Groupid { get; set; }

    public long? Userid { get; set; }

    public long? Available { get; set; }

    public long? Deadline { get; set; }

    public long? Timelimit { get; set; }

    public short? Review { get; set; }

    public short? Maxattempts { get; set; }

    public short? Retake { get; set; }

    public string? Password { get; set; }
}
