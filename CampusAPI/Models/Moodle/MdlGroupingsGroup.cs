using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Link a grouping to a group (note, groups can be in multiple 
/// </summary>
public partial class MdlGroupingsGroup
{
    public long Id { get; set; }

    public long Groupingid { get; set; }

    public long Groupid { get; set; }

    public long Timeadded { get; set; }
}
