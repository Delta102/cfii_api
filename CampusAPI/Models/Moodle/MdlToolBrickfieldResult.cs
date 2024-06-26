using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Results of the accessibility checks
/// </summary>
public partial class MdlToolBrickfieldResult
{
    public long Id { get; set; }

    public long? Contentid { get; set; }

    public long Checkid { get; set; }

    public long Errorcount { get; set; }
}
