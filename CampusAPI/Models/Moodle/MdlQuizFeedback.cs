using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Feedback given to students based on which grade band their o
/// </summary>
public partial class MdlQuizFeedback
{
    public long Id { get; set; }

    public long Quizid { get; set; }

    public string Feedbacktext { get; set; } = null!;

    public sbyte Feedbacktextformat { get; set; }

    public decimal Mingrade { get; set; }

    public decimal Maxgrade { get; set; }
}
