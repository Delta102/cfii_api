using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines badge related for badges
/// </summary>
public partial class MdlBadgeRelated
{
    public long Id { get; set; }

    public long Badgeid { get; set; }

    public long? Relatedbadgeid { get; set; }
}
