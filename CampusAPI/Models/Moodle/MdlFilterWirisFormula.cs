using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Default comment for filter_wiris, please edit me
/// </summary>
public partial class MdlFilterWirisFormula
{
    public long Id { get; set; }

    public string Md5 { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string? Jsoncontent { get; set; }

    public string? Alt { get; set; }

    public long Timecreated { get; set; }
}
