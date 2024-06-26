using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Info about the submission and the aggregation of the grade f
/// </summary>
public partial class MdlWorkshopSubmission
{
    public long Id { get; set; }

    public long Workshopid { get; set; }

    public sbyte? Example { get; set; }

    public long Authorid { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public string Title { get; set; } = null!;

    public string? Content { get; set; }

    public short Contentformat { get; set; }

    public short Contenttrust { get; set; }

    public sbyte? Attachment { get; set; }

    public decimal? Grade { get; set; }

    public decimal? Gradeover { get; set; }

    public long? Gradeoverby { get; set; }

    public string? Feedbackauthor { get; set; }

    public short? Feedbackauthorformat { get; set; }

    public long? Timegraded { get; set; }

    public sbyte? Published { get; set; }

    public sbyte Late { get; set; }
}
