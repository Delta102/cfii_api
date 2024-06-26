using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Table to track file conversions.
/// </summary>
public partial class MdlFileConversion
{
    public long Id { get; set; }

    public long Usermodified { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Sourcefileid { get; set; }

    public string Targetformat { get; set; } = null!;

    public long? Status { get; set; }

    public string? Statusmessage { get; set; }

    public string? Converter { get; set; }

    public long? Destfileid { get; set; }

    public string? Data { get; set; }
}
