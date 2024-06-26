using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Cache of time-sensitive flags
/// </summary>
public partial class MdlCacheFlag
{
    public long Id { get; set; }

    public string Flagtype { get; set; } = null!;

    public string Name { get; set; } = null!;

    public long Timemodified { get; set; }

    public string Value { get; set; } = null!;

    public long Expiry { get; set; }
}
