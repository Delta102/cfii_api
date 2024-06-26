using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// backup of all old resource instances from 1.9
/// </summary>
public partial class MdlResourceOld
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string? Intro { get; set; }

    public short Introformat { get; set; }

    public string Alltext { get; set; } = null!;

    public string Popup { get; set; } = null!;

    public string Options { get; set; } = null!;

    public long Timemodified { get; set; }

    public long Oldid { get; set; }

    public long? Cmid { get; set; }

    public string? Newmodule { get; set; }

    public long? Newid { get; set; }

    public long Migrated { get; set; }
}
