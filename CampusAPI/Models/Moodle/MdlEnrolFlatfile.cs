using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// enrol_flatfile table retrofitted from MySQL
/// </summary>
public partial class MdlEnrolFlatfile
{
    public long Id { get; set; }

    public string Action { get; set; } = null!;

    public long Roleid { get; set; }

    public long Userid { get; set; }

    public long Courseid { get; set; }

    public long Timestart { get; set; }

    public long Timeend { get; set; }

    public long Timemodified { get; set; }
}
