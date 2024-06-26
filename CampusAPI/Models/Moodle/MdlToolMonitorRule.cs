using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Table to store rules
/// </summary>
public partial class MdlToolMonitorRule
{
    public long Id { get; set; }

    public string? Description { get; set; }

    public bool Descriptionformat { get; set; }

    public string Name { get; set; } = null!;

    public long Userid { get; set; }

    public long Courseid { get; set; }

    public string Plugin { get; set; } = null!;

    public string Eventname { get; set; } = null!;

    public string Template { get; set; } = null!;

    public bool Templateformat { get; set; }

    public short Frequency { get; set; }

    public int Timewindow { get; set; }

    public long Timemodified { get; set; }

    public long Timecreated { get; set; }
}
