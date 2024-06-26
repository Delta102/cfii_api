using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// grade_grades  This table keeps individual grades for each us
/// </summary>
public partial class MdlGradeGrade
{
    public long Id { get; set; }

    public long Itemid { get; set; }

    public long Userid { get; set; }

    public decimal? Rawgrade { get; set; }

    public decimal Rawgrademax { get; set; }

    public decimal Rawgrademin { get; set; }

    public long? Rawscaleid { get; set; }

    public long? Usermodified { get; set; }

    public decimal? Finalgrade { get; set; }

    public long Hidden { get; set; }

    public long Locked { get; set; }

    public long Locktime { get; set; }

    public long Exported { get; set; }

    public long Overridden { get; set; }

    public long Excluded { get; set; }

    public string? Feedback { get; set; }

    public long Feedbackformat { get; set; }

    public string? Information { get; set; }

    public long Informationformat { get; set; }

    public long? Timecreated { get; set; }

    public long? Timemodified { get; set; }

    public string Aggregationstatus { get; set; } = null!;

    public decimal? Aggregationweight { get; set; }
}
