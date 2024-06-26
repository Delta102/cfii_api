using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// the questions conforming one survey
/// </summary>
public partial class MdlSurveyQuestion
{
    public long Id { get; set; }

    public string Text { get; set; } = null!;

    public string Shorttext { get; set; } = null!;

    public string Multi { get; set; } = null!;

    public string Intro { get; set; } = null!;

    public short Type { get; set; }

    public string? Options { get; set; }
}
