using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Contains the basic information about an advanced grading for
/// </summary>
public partial class MdlGradingDefinition
{
    public long Id { get; set; }

    public long Areaid { get; set; }

    public string Method { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public sbyte? Descriptionformat { get; set; }

    public long Status { get; set; }

    public long? Copiedfromid { get; set; }

    public long Timecreated { get; set; }

    public long Usercreated { get; set; }

    public long Timemodified { get; set; }

    public long Usermodified { get; set; }

    public long? Timecopied { get; set; }

    public string? Options { get; set; }
}
