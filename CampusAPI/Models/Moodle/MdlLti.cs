using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This table contains Basic LTI activities instances
/// </summary>
public partial class MdlLti
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string? Intro { get; set; }

    public short? Introformat { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long? Typeid { get; set; }

    public string Toolurl { get; set; } = null!;

    public string? Securetoolurl { get; set; }

    public bool? Instructorchoicesendname { get; set; }

    public bool? Instructorchoicesendemailaddr { get; set; }

    public bool? Instructorchoiceallowroster { get; set; }

    public bool? Instructorchoiceallowsetting { get; set; }

    public string? Instructorcustomparameters { get; set; }

    public bool? Instructorchoiceacceptgrades { get; set; }

    public long Grade { get; set; }

    public sbyte Launchcontainer { get; set; }

    public string? Resourcekey { get; set; }

    public string? Password { get; set; }

    public bool Debuglaunch { get; set; }

    public bool Showtitlelaunch { get; set; }

    public bool Showdescriptionlaunch { get; set; }

    public string? Servicesalt { get; set; }

    public string? Icon { get; set; }

    public string? Secureicon { get; set; }
}
