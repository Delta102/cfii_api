using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// For keeping information about cached data
/// </summary>
public partial class MdlCacheFilter
{
    public long Id { get; set; }

    public string Filter { get; set; } = null!;

    public long Version { get; set; }

    public string Md5key { get; set; } = null!;

    public string Rawtext { get; set; } = null!;

    public long Timemodified { get; set; }
}
