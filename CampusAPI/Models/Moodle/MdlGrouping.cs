using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// A grouping is a collection of groups. WAS: groups_groupings
/// </summary>
public partial class MdlGrouping
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public string Name { get; set; } = null!;

    public string Idnumber { get; set; } = null!;

    public string? Description { get; set; }

    public sbyte Descriptionformat { get; set; }

    public string? Configdata { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
