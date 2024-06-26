using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// The assessment dimensions definitions of Accumulative gradin
/// </summary>
public partial class MdlWorkshopformAccumulative
{
    public long Id { get; set; }

    public long Workshopid { get; set; }

    public long? Sort { get; set; }

    public string? Description { get; set; }

    public short? Descriptionformat { get; set; }

    public long Grade { get; set; }

    public int? Weight { get; set; }
}
