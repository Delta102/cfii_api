using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// The evidence of prior learning
/// </summary>
public partial class MdlCompetencyUserevidence
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool Descriptionformat { get; set; }

    public string Url { get; set; } = null!;

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Usermodified { get; set; }
}
