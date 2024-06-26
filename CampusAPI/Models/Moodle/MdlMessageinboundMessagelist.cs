using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// A list of message IDs for existing replies
/// </summary>
public partial class MdlMessageinboundMessagelist
{
    public long Id { get; set; }

    public string Messageid { get; set; } = null!;

    public long Userid { get; set; }

    public string Address { get; set; } = null!;

    public long Timecreated { get; set; }
}
