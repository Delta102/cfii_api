using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores wiki pages
/// </summary>
public partial class MdlWikiPage
{
    public long Id { get; set; }

    public long Subwikiid { get; set; }

    public string Title { get; set; } = null!;

    public string Cachedcontent { get; set; } = null!;

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Timerendered { get; set; }

    public long Userid { get; set; }

    public long Pageviews { get; set; }

    public bool Readonly { get; set; }
}
