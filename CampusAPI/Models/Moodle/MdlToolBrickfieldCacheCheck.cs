using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Contains accessibility summary information per check.
/// </summary>
public partial class MdlToolBrickfieldCacheCheck
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public bool? Status { get; set; }

    public long? Checkid { get; set; }

    public long? Checkcount { get; set; }

    public long? Errorcount { get; set; }
}
