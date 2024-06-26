using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// base table (not including config data) for instances of port
/// </summary>
public partial class MdlPortfolioInstance
{
    public long Id { get; set; }

    public string Plugin { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool? Visible { get; set; }
}
