using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Extra user pages for the My Moodle system
/// </summary>
public partial class MdlMyPage
{
    public long Id { get; set; }

    public long? Userid { get; set; }

    public string Name { get; set; } = null!;

    public bool? Private { get; set; }

    public int Sortorder { get; set; }
}
