using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores teacher specified quicklist comments
/// </summary>
public partial class MdlAssignfeedbackEditpdfQuick
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public string Rawtext { get; set; } = null!;

    public long Width { get; set; }

    public string? Colour { get; set; }
}
