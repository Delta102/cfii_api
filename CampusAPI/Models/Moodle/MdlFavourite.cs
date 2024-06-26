using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the relationship between an arbitrary item (itemtype,
/// </summary>
public partial class MdlFavourite
{
    public long Id { get; set; }

    public string Component { get; set; } = null!;

    public string Itemtype { get; set; } = null!;

    public long Itemid { get; set; }

    public long Contextid { get; set; }

    public long Userid { get; set; }

    public long? Ordering { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
