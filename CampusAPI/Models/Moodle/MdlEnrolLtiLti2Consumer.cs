using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// LTI consumers interacting with moodle
/// </summary>
public partial class MdlEnrolLtiLti2Consumer
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Consumerkey256 { get; set; } = null!;

    public string? Consumerkey { get; set; }

    public string Secret { get; set; } = null!;

    public string? Ltiversion { get; set; }

    public string? Consumername { get; set; }

    public string? Consumerversion { get; set; }

    public string? Consumerguid { get; set; }

    public string? Profile { get; set; }

    public string? Toolproxy { get; set; }

    public string? Settings { get; set; }

    public bool Protected { get; set; }

    public bool Enabled { get; set; }

    public long? Enablefrom { get; set; }

    public long? Enableuntil { get; set; }

    public long? Lastaccess { get; set; }

    public long Created { get; set; }

    public long Updated { get; set; }
}
