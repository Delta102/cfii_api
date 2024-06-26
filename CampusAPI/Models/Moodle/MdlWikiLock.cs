using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Manages page locks
/// </summary>
public partial class MdlWikiLock
{
    public long Id { get; set; }

    public long Pageid { get; set; }

    public string? Sectionname { get; set; }

    public long Userid { get; set; }

    public long Lockedat { get; set; }
}
