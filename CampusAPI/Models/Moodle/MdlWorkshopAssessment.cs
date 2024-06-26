using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Info about the made assessment and automatically calculated 
/// </summary>
public partial class MdlWorkshopAssessment
{
    public long Id { get; set; }

    public long Submissionid { get; set; }

    public long Reviewerid { get; set; }

    public long Weight { get; set; }

    public long? Timecreated { get; set; }

    public long? Timemodified { get; set; }

    public decimal? Grade { get; set; }

    public decimal? Gradinggrade { get; set; }

    public decimal? Gradinggradeover { get; set; }

    public long? Gradinggradeoverby { get; set; }

    public string? Feedbackauthor { get; set; }

    public short? Feedbackauthorformat { get; set; }

    public short? Feedbackauthorattachment { get; set; }

    public string? Feedbackreviewer { get; set; }

    public short? Feedbackreviewerformat { get; set; }
}
