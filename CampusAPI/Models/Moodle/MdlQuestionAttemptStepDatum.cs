using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Each question_attempt_step has an associative array of the d
/// </summary>
public partial class MdlQuestionAttemptStepDatum
{
    public long Id { get; set; }

    public long Attemptstepid { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
