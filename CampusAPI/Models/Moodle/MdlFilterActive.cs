using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores information about which filters are active in which c
/// </summary>
public partial class MdlFilterActive
{
    public long Id { get; set; }

    public string Filter { get; set; } = null!;

    public long Contextid { get; set; }

    public short Active { get; set; }

    public long Sortorder { get; set; }
}
