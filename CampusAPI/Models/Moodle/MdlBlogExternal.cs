using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// External blog links used for RSS copying of blog entries to 
/// </summary>
public partial class MdlBlogExternal
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Url { get; set; } = null!;

    public string? Filtertags { get; set; }

    public bool Failedlastsync { get; set; }

    public long? Timemodified { get; set; }

    public long Timefetched { get; set; }
}
