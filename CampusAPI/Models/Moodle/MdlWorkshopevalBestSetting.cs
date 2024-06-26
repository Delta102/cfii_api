using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Settings for the grading evaluation subplugin Comparison wit
/// </summary>
public partial class MdlWorkshopevalBestSetting
{
    public long Id { get; set; }

    public long Workshopid { get; set; }

    public short? Comparison { get; set; }
}
