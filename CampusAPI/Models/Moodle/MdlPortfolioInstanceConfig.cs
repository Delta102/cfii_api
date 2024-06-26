using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// config for portfolio plugin instances
/// </summary>
public partial class MdlPortfolioInstanceConfig
{
    public long Id { get; set; }

    public long Instance { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
