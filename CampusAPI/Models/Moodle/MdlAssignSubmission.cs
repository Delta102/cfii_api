using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This table keeps information about student interactions with
/// </summary>
public partial class MdlAssignSubmission
{
    public long Id { get; set; }

    public long Assignment { get; set; }

    public long Userid { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public string? Status { get; set; }

    public long Groupid { get; set; }

    public long Attemptnumber { get; set; }

    public sbyte Latest { get; set; }
}
