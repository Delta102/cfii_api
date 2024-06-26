using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// each record is one url resource
/// </summary>
public partial class MdlUrl
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string? Intro { get; set; }

    public short Introformat { get; set; }

    public string Externalurl { get; set; } = null!;

    public short Display { get; set; }

    public string? Displayoptions { get; set; }

    public string? Parameters { get; set; }

    public long Timemodified { get; set; }
}
