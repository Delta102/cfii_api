using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Data purpose overrides for a specific role
/// </summary>
public partial class MdlToolDataprivacyPurposerole
{
    public long Id { get; set; }

    public long Purposeid { get; set; }

    public long Roleid { get; set; }

    public string? Lawfulbases { get; set; }

    public string? Sensitivedatareasons { get; set; }

    public string Retentionperiod { get; set; } = null!;

    public bool? Protected { get; set; }

    public long Usermodified { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
