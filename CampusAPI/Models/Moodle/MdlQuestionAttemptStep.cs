using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores one step in in a question attempt. As well as the dat
/// </summary>
public partial class MdlQuestionAttemptStep
{
    public long Id { get; set; }

    public long Questionattemptid { get; set; }

    public long Sequencenumber { get; set; }

    public string State { get; set; } = null!;

    public decimal? Fraction { get; set; }

    public long Timecreated { get; set; }

    public long? Userid { get; set; }
}
