using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines lesson
/// </summary>
public partial class MdlLesson
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string? Intro { get; set; }

    public short Introformat { get; set; }

    public short Practice { get; set; }

    public short Modattempts { get; set; }

    public short Usepassword { get; set; }

    public string Password { get; set; } = null!;

    public long Dependency { get; set; }

    public string Conditions { get; set; } = null!;

    public long Grade { get; set; }

    public short Custom { get; set; }

    public short Ongoing { get; set; }

    public short Usemaxgrade { get; set; }

    public short Maxanswers { get; set; }

    public short Maxattempts { get; set; }

    public short Review { get; set; }

    public short Nextpagedefault { get; set; }

    public short Feedback { get; set; }

    public short Minquestions { get; set; }

    public short Maxpages { get; set; }

    public long Timelimit { get; set; }

    public short Retake { get; set; }

    public long Activitylink { get; set; }

    public string Mediafile { get; set; } = null!;

    public long Mediaheight { get; set; }

    public long Mediawidth { get; set; }

    public short Mediaclose { get; set; }

    public short Slideshow { get; set; }

    public long Width { get; set; }

    public long Height { get; set; }

    public string Bgcolor { get; set; } = null!;

    public short Displayleft { get; set; }

    public short Displayleftif { get; set; }

    public short Progressbar { get; set; }

    public long Available { get; set; }

    public long Deadline { get; set; }

    public long Timemodified { get; set; }

    public bool? Completionendreached { get; set; }

    public long? Completiontimespent { get; set; }

    public bool? Allowofflineattempts { get; set; }
}
