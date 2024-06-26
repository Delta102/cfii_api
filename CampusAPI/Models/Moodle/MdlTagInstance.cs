using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// tag_instance table holds the information of associations bet
/// </summary>
public partial class MdlTagInstance
{
    public long Id { get; set; }

    public long Tagid { get; set; }

    public string Component { get; set; } = null!;

    public string Itemtype { get; set; } = null!;

    public long Itemid { get; set; }

    public long? Contextid { get; set; }

    public long Tiuserid { get; set; }

    public long? Ordering { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
