using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// To keep track of course page access times, used in online pa
/// </summary>
public partial class MdlUserLastaccess
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Courseid { get; set; }

    public long Timeaccess { get; set; }
}
