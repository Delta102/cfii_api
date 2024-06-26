using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// user data for portfolio instances.
/// </summary>
public partial class MdlPortfolioInstanceUser
{
    public long Id { get; set; }

    public long Instance { get; set; }

    public long Userid { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
