using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// The assessment dimensions definitions of Number of errors gr
/// </summary>
public partial class MdlWorkshopformNumerror
{
    public long Id { get; set; }

    public long Workshopid { get; set; }

    public long? Sort { get; set; }

    public string? Description { get; set; }

    public short? Descriptionformat { get; set; }

    public long? Descriptiontrust { get; set; }

    public string? Grade0 { get; set; }

    public string? Grade1 { get; set; }

    public int? Weight { get; set; }
}
