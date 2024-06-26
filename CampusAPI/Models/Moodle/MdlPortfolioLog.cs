using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// log of portfolio transfers (used to later check for duplicat
/// </summary>
public partial class MdlPortfolioLog
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Time { get; set; }

    public long Portfolio { get; set; }

    public string CallerClass { get; set; } = null!;

    public string CallerFile { get; set; } = null!;

    public string? CallerComponent { get; set; }

    public string CallerSha1 { get; set; } = null!;

    public long Tempdataid { get; set; }

    public string Returnurl { get; set; } = null!;

    public string Continueurl { get; set; } = null!;
}
