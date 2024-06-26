using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Data purposes
/// </summary>
public partial class MdlToolDataprivacyPurpose
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool? Descriptionformat { get; set; }

    public string Lawfulbases { get; set; } = null!;

    public string? Sensitivedatareasons { get; set; }

    public string Retentionperiod { get; set; } = null!;

    public bool? Protected { get; set; }

    public long Usermodified { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
