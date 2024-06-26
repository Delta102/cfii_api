using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Inbound Message Handler definitions.
/// </summary>
public partial class MdlMessageinboundHandler
{
    public long Id { get; set; }

    public string Component { get; set; } = null!;

    public string Classname { get; set; } = null!;

    public long Defaultexpiration { get; set; }

    public bool? Validateaddress { get; set; }

    public bool Enabled { get; set; }
}
