using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Data categories
/// </summary>
public partial class MdlToolDataprivacyCategory
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool? Descriptionformat { get; set; }

    public long Usermodified { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
