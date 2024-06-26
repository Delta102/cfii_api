using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Community block
/// </summary>
public partial class MdlBlockCommunity
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public string Coursename { get; set; } = null!;

    public string? Coursedescription { get; set; }

    public string Courseurl { get; set; } = null!;

    public string Imageurl { get; set; } = null!;
}
