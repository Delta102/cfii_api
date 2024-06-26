using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the position of a sticky block_instance on a another 
/// </summary>
public partial class MdlBlockPosition
{
    public long Id { get; set; }

    public long Blockinstanceid { get; set; }

    public long Contextid { get; set; }

    public string Pagetype { get; set; } = null!;

    public string Subpage { get; set; } = null!;

    public short Visible { get; set; }

    public string Region { get; set; } = null!;

    public long Weight { get; set; }
}
