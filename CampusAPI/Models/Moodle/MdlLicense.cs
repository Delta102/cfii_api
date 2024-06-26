using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// store licenses used by moodle
/// </summary>
public partial class MdlLicense
{
    public long Id { get; set; }

    public string? Shortname { get; set; }

    public string? Fullname { get; set; }

    public string? Source { get; set; }

    public bool? Enabled { get; set; }

    public long Version { get; set; }

    public bool Custom { get; set; }

    public int Sortorder { get; set; }
}
