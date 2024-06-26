using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// List of tools provided to the remote system
/// </summary>
public partial class MdlEnrolLtiTool
{
    public long Id { get; set; }

    public long Enrolid { get; set; }

    public long Contextid { get; set; }

    public string Institution { get; set; } = null!;

    public string Lang { get; set; } = null!;

    public string Timezone { get; set; } = null!;

    public long Maxenrolled { get; set; }

    public sbyte Maildisplay { get; set; }

    public string City { get; set; } = null!;

    public string Country { get; set; } = null!;

    public bool Gradesync { get; set; }

    public bool Gradesynccompletion { get; set; }

    public bool Membersync { get; set; }

    public bool Membersyncmode { get; set; }

    public long Roleinstructor { get; set; }

    public long Rolelearner { get; set; }

    public string? Secret { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
