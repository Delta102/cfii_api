using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Most recently accessed items accessed by a user
/// </summary>
public partial class MdlBlockRecentlyaccesseditem
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public long Cmid { get; set; }

    public long Userid { get; set; }

    public long Timeaccess { get; set; }
}
