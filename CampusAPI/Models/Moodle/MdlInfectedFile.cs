using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlInfectedFile
{
    public long Id { get; set; }

    public string Filename { get; set; } = null!;

    public string? Quarantinedfile { get; set; }

    public long Userid { get; set; }

    public string Reason { get; set; } = null!;

    public long Timecreated { get; set; }
}
