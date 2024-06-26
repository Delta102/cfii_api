using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// LTI tool setting values
/// </summary>
public partial class MdlLtiToolSetting
{
    public long Id { get; set; }

    public long Toolproxyid { get; set; }

    public long? Typeid { get; set; }

    public long? Course { get; set; }

    public long? Coursemoduleid { get; set; }

    public string Settings { get; set; } = null!;

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
