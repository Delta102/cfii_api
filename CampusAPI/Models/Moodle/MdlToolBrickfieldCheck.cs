using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Checks details
/// </summary>
public partial class MdlToolBrickfieldCheck
{
    public long Id { get; set; }

    public string? Checktype { get; set; }

    public string? Shortname { get; set; }

    public long? Checkgroup { get; set; }

    public short Status { get; set; }

    public sbyte Severity { get; set; }
}
