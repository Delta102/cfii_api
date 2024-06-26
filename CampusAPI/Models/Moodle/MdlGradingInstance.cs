using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Grading form instance is an assessment record for one gradab
/// </summary>
public partial class MdlGradingInstance
{
    public long Id { get; set; }

    public long Definitionid { get; set; }

    public long Raterid { get; set; }

    public long? Itemid { get; set; }

    public decimal? Rawgrade { get; set; }

    public long Status { get; set; }

    public string? Feedback { get; set; }

    public sbyte? Feedbackformat { get; set; }

    public long Timemodified { get; set; }
}
