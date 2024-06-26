using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Options for questions of type calculated
/// </summary>
public partial class MdlQuestionCalculated
{
    public long Id { get; set; }

    public long Question { get; set; }

    public long Answer { get; set; }

    public string Tolerance { get; set; } = null!;

    public long Tolerancetype { get; set; }

    public long Correctanswerlength { get; set; }

    public long Correctanswerformat { get; set; }
}
