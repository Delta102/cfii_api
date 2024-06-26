using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores Wiki activity configuration
/// </summary>
public partial class MdlWiki
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string? Intro { get; set; }

    public short Introformat { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public string Firstpagetitle { get; set; } = null!;

    public string Wikimode { get; set; } = null!;

    public string Defaultformat { get; set; } = null!;

    public bool? Forceformat { get; set; }

    public long Editbegin { get; set; }

    public long? Editend { get; set; }
}
