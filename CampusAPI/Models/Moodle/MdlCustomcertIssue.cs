using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores each issue of a customcert
/// </summary>
public partial class MdlCustomcertIssue
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Customcertid { get; set; }

    public string? Code { get; set; }

    public bool Emailed { get; set; }

    public long Timecreated { get; set; }
}
