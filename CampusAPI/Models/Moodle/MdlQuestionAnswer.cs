using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Answers, with a fractional grade (0-1) and feedback
/// </summary>
public partial class MdlQuestionAnswer
{
    public long Id { get; set; }

    public long Question { get; set; }

    public string Answer { get; set; } = null!;

    public sbyte Answerformat { get; set; }

    public decimal Fraction { get; set; }

    public string Feedback { get; set; } = null!;

    public sbyte Feedbackformat { get; set; }
}
