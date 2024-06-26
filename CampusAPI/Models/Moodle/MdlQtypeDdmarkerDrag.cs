using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Labels for markers to drag.
/// </summary>
public partial class MdlQtypeDdmarkerDrag
{
    public long Id { get; set; }

    public long Questionid { get; set; }

    public long No { get; set; }

    public string Label { get; set; } = null!;

    public short Infinite { get; set; }

    public long Noofdrags { get; set; }
}
