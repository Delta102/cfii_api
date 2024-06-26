using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// each record is one imscp resource
/// </summary>
public partial class MdlImscp
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string? Intro { get; set; }

    public short Introformat { get; set; }

    public long Revision { get; set; }

    public long Keepold { get; set; }

    public string? Structure { get; set; }

    public long Timemodified { get; set; }
}
