using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Statistics for individual questions used in an activity.
/// </summary>
public partial class MdlQuestionStatistic
{
    public long Id { get; set; }

    public string Hashcode { get; set; } = null!;

    public long Timemodified { get; set; }

    public long Questionid { get; set; }

    public long? Slot { get; set; }

    public short Subquestion { get; set; }

    public long? Variant { get; set; }

    public long S { get; set; }

    public decimal? Effectiveweight { get; set; }

    public sbyte Negcovar { get; set; }

    public decimal? Discriminationindex { get; set; }

    public decimal? Discriminativeefficiency { get; set; }

    public decimal? Sd { get; set; }

    public decimal? Facility { get; set; }

    public string? Subquestions { get; set; }

    public decimal? Maxmark { get; set; }

    public string? Positions { get; set; }

    public decimal? Randomguessscore { get; set; }
}
