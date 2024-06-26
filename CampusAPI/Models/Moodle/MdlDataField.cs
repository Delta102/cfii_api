using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// every field available
/// </summary>
public partial class MdlDataField
{
    public long Id { get; set; }

    public long Dataid { get; set; }

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool Required { get; set; }

    public string? Param1 { get; set; }

    public string? Param2 { get; set; }

    public string? Param3 { get; set; }

    public string? Param4 { get; set; }

    public string? Param5 { get; set; }

    public string? Param6 { get; set; }

    public string? Param7 { get; set; }

    public string? Param8 { get; set; }

    public string? Param9 { get; set; }

    public string? Param10 { get; set; }
}
