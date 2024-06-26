using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Customisable user profile fields
/// </summary>
public partial class MdlUserInfoField
{
    public long Id { get; set; }

    public string Shortname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Datatype { get; set; } = null!;

    public string? Description { get; set; }

    public sbyte Descriptionformat { get; set; }

    public long Categoryid { get; set; }

    public long Sortorder { get; set; }

    public sbyte Required { get; set; }

    public sbyte Locked { get; set; }

    public short Visible { get; set; }

    public sbyte Forceunique { get; set; }

    public sbyte Signup { get; set; }

    public string? Defaultdata { get; set; }

    public sbyte Defaultdataformat { get; set; }

    public string? Param1 { get; set; }

    public string? Param2 { get; set; }

    public string? Param3 { get; set; }

    public string? Param4 { get; set; }

    public string? Param5 { get; set; }
}
