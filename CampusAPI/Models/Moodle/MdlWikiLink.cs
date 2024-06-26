using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Page wiki links
/// </summary>
public partial class MdlWikiLink
{
    public long Id { get; set; }

    public long Subwikiid { get; set; }

    public long Frompageid { get; set; }

    public long Topageid { get; set; }

    public string? Tomissingpage { get; set; }
}
