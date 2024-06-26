using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// stores temporary data for portfolio exports. the id of this 
/// </summary>
public partial class MdlPortfolioTempdatum
{
    public long Id { get; set; }

    public string? Data { get; set; }

    public long Expirytime { get; set; }

    public long Userid { get; set; }

    public long? Instance { get; set; }

    public bool Queued { get; set; }
}
