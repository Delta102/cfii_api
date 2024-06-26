using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines lesson_answers
/// </summary>
public partial class MdlLessonAnswer
{
    public long Id { get; set; }

    public long Lessonid { get; set; }

    public long Pageid { get; set; }

    public long Jumpto { get; set; }

    public short Grade { get; set; }

    public long Score { get; set; }

    public short Flags { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public string? Answer { get; set; }

    public sbyte Answerformat { get; set; }

    public string? Response { get; set; }

    public sbyte Responseformat { get; set; }
}
