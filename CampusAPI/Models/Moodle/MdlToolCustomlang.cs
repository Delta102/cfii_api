using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Contains the working checkout of all strings and their custo
/// </summary>
public partial class MdlToolCustomlang
{
    public long Id { get; set; }

    public string Lang { get; set; } = null!;

    public long Componentid { get; set; }

    public string Stringid { get; set; } = null!;

    public string Original { get; set; } = null!;

    public string? Master { get; set; }

    public string? Local { get; set; }

    public long Timemodified { get; set; }

    public long? Timecustomized { get; set; }

    public short? Outdated { get; set; }

    public short? Modified { get; set; }
}
