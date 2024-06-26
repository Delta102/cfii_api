using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores users attempts at quizzes.
/// </summary>
public partial class MdlQuizAttempt
{
    public long Id { get; set; }

    public long Quiz { get; set; }

    public long Userid { get; set; }

    public int Attempt { get; set; }

    public long Uniqueid { get; set; }

    public string Layout { get; set; } = null!;

    public long Currentpage { get; set; }

    public short Preview { get; set; }

    public string State { get; set; } = null!;

    public long Timestart { get; set; }

    public long Timefinish { get; set; }

    public long Timemodified { get; set; }

    public long Timemodifiedoffline { get; set; }

    public long? Timecheckstate { get; set; }

    public decimal? Sumgrades { get; set; }
}
