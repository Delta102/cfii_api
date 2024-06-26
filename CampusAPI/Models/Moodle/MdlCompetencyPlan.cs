using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Learning plans
/// </summary>
public partial class MdlCompetencyPlan
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public short Descriptionformat { get; set; }

    public long Userid { get; set; }

    public long? Templateid { get; set; }

    public long? Origtemplateid { get; set; }

    public bool Status { get; set; }

    public long? Duedate { get; set; }

    public long? Reviewerid { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Usermodified { get; set; }
}
