using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines badge
/// </summary>
public partial class MdlBadge
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Usercreated { get; set; }

    public long Usermodified { get; set; }

    public string Issuername { get; set; } = null!;

    public string Issuerurl { get; set; } = null!;

    public string? Issuercontact { get; set; }

    public long? Expiredate { get; set; }

    public long? Expireperiod { get; set; }

    public bool? Type { get; set; }

    public long? Courseid { get; set; }

    public string Message { get; set; } = null!;

    public string Messagesubject { get; set; } = null!;

    public bool? Attachment { get; set; }

    public bool? Notification { get; set; }

    public bool Status { get; set; }

    public long? Nextcron { get; set; }

    public string? Version { get; set; }

    public string? Language { get; set; }

    public string? Imageauthorname { get; set; }

    public string? Imageauthoremail { get; set; }

    public string? Imageauthorurl { get; set; }

    public string? Imagecaption { get; set; }
}
