using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Images to drag. Actual file names are not stored here we use
/// </summary>
public partial class MdlQtypeDdimageortextDrag
{
    public long Id { get; set; }

    public long Questionid { get; set; }

    public long No { get; set; }

    public long Draggroup { get; set; }

    public short Infinite { get; set; }

    public string Label { get; set; } = null!;
}
