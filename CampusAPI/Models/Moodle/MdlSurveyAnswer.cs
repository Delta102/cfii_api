using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// the answers to each questions filled by the users
/// </summary>
public partial class MdlSurveyAnswer
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Survey { get; set; }

    public long Question { get; set; }

    public long Time { get; set; }

    public string Answer1 { get; set; } = null!;

    public string Answer2 { get; set; } = null!;
}
