using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Learning plan templates.
/// </summary>
public partial class MdlCompetencyTemplate
{
    public long Id { get; set; }

    public string? Shortname { get; set; }

    public long Contextid { get; set; }

    public string? Description { get; set; }

    public short Descriptionformat { get; set; }

    public sbyte Visible { get; set; }

    public long? Duedate { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long? Usermodified { get; set; }
}
