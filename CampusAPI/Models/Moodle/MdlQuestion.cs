using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// The questions themselves
/// </summary>
public partial class MdlQuestion
{
    public long Id { get; set; }

    public long Category { get; set; }

    public long Parent { get; set; }

    public string Name { get; set; } = null!;

    public string Questiontext { get; set; } = null!;

    public sbyte Questiontextformat { get; set; }

    public string Generalfeedback { get; set; } = null!;

    public sbyte Generalfeedbackformat { get; set; }

    public decimal Defaultmark { get; set; }

    public decimal Penalty { get; set; }

    public string Qtype { get; set; } = null!;

    public long Length { get; set; }

    public string Stamp { get; set; } = null!;

    public string Version { get; set; } = null!;

    public bool Hidden { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long? Createdby { get; set; }

    public long? Modifiedby { get; set; }

    public string? Idnumber { get; set; }
}
