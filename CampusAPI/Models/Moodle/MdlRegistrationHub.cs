using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// hub where the site is registered on with their associated to
/// </summary>
public partial class MdlRegistrationHub
{
    public long Id { get; set; }

    public string Token { get; set; } = null!;

    public string Hubname { get; set; } = null!;

    public string Huburl { get; set; } = null!;

    public bool Confirmed { get; set; }

    public string? Secret { get; set; }

    public long Timemodified { get; set; }
}
