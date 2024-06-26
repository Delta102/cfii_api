using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// List of competency frameworks.
/// </summary>
public partial class MdlCompetencyFramework
{
    public long Id { get; set; }

    public string? Shortname { get; set; }

    public long Contextid { get; set; }

    public string? Idnumber { get; set; }

    public string? Description { get; set; }

    public short Descriptionformat { get; set; }

    public long? Scaleid { get; set; }

    public string Scaleconfiguration { get; set; } = null!;

    public sbyte Visible { get; set; }

    public string Taxonomies { get; set; } = null!;

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long? Usermodified { get; set; }
}
