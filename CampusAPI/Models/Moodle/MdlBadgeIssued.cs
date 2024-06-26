using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines issued badges
/// </summary>
public partial class MdlBadgeIssued
{
    public long Id { get; set; }

    public long Badgeid { get; set; }

    public long Userid { get; set; }

    public string Uniquehash { get; set; } = null!;

    public long Dateissued { get; set; }

    public long? Dateexpire { get; set; }

    public bool Visible { get; set; }

    public long? Issuernotified { get; set; }
}
