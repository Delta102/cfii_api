using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Repository for grade letters, for courses and other moodle e
/// </summary>
public partial class MdlGradeLetter
{
    public long Id { get; set; }

    public long Contextid { get; set; }

    public decimal Lowerboundary { get; set; }

    public string Letter { get; set; } = null!;
}
