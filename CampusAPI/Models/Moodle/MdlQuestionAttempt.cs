using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Each row here corresponds to an attempt at one question, as 
/// </summary>
public partial class MdlQuestionAttempt
{
    public long Id { get; set; }

    public long Questionusageid { get; set; }

    public long Slot { get; set; }

    public string Behaviour { get; set; } = null!;

    public long Questionid { get; set; }

    public long Variant { get; set; }

    public decimal Maxmark { get; set; }

    public decimal Minfraction { get; set; }

    public decimal Maxfraction { get; set; }

    public bool Flagged { get; set; }

    public string? Questionsummary { get; set; }

    public string? Rightanswer { get; set; }

    public string? Responsesummary { get; set; }

    public long Timemodified { get; set; }
}
