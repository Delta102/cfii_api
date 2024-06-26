using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines labels
/// </summary>
public partial class MdlLabel
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string Intro { get; set; } = null!;

    public short? Introformat { get; set; }

    public long Timemodified { get; set; }
}
