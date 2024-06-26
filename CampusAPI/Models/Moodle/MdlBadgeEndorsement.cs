using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines endorsement for badge
/// </summary>
public partial class MdlBadgeEndorsement
{
    public long Id { get; set; }

    public long Badgeid { get; set; }

    public string Issuername { get; set; } = null!;

    public string Issuerurl { get; set; } = null!;

    public string Issueremail { get; set; } = null!;

    public string? Claimid { get; set; }

    public string? Claimcomment { get; set; }

    public long Dateissued { get; set; }
}
