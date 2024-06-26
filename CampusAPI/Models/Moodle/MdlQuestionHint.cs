using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the the part of the question definition that gives di
/// </summary>
public partial class MdlQuestionHint
{
    public long Id { get; set; }

    public long Questionid { get; set; }

    public string Hint { get; set; } = null!;

    public short Hintformat { get; set; }

    public bool? Shownumcorrect { get; set; }

    public bool? Clearwrong { get; set; }

    public string? Options { get; set; }
}
