using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// The evidence linked to a user competency
/// </summary>
public partial class MdlCompetencyEvidence
{
    public long Id { get; set; }

    public long Usercompetencyid { get; set; }

    public long Contextid { get; set; }

    public sbyte Action { get; set; }

    public long? Actionuserid { get; set; }

    public string Descidentifier { get; set; } = null!;

    public string Desccomponent { get; set; } = null!;

    public string? Desca { get; set; }

    public string? Url { get; set; }

    public long? Grade { get; set; }

    public string? Note { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Usermodified { get; set; }
}
