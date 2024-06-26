using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores wiki page history
/// </summary>
public partial class MdlWikiVersion
{
    public long Id { get; set; }

    public long Pageid { get; set; }

    public string Content { get; set; } = null!;

    public string Contentformat { get; set; } = null!;

    public int Version { get; set; }

    public long Timecreated { get; set; }

    public long Userid { get; set; }
}
