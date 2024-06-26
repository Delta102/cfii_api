using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// maps mahara tokens to transfer ids
/// </summary>
public partial class MdlPortfolioMaharaQueue
{
    public long Id { get; set; }

    public long Transferid { get; set; }

    public string Token { get; set; } = null!;
}
