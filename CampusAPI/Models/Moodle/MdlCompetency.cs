using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This table contains the master record of each competency in 
/// </summary>
public partial class MdlCompetency
{
    public long Id { get; set; }

    public string? Shortname { get; set; }

    public string? Description { get; set; }

    public short Descriptionformat { get; set; }

    public string? Idnumber { get; set; }

    public long Competencyframeworkid { get; set; }

    public long Parentid { get; set; }

    public string Path { get; set; } = null!;

    public long Sortorder { get; set; }

    public string? Ruletype { get; set; }

    public sbyte Ruleoutcome { get; set; }

    public string? Ruleconfig { get; set; }

    public long? Scaleid { get; set; }

    public string? Scaleconfiguration { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long? Usermodified { get; set; }
}
