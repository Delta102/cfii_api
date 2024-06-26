using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlH5p
{
    public long Id { get; set; }

    public string Jsoncontent { get; set; } = null!;

    public long Mainlibraryid { get; set; }

    public short? Displayoptions { get; set; }

    public string Pathnamehash { get; set; } = null!;

    public string Contenthash { get; set; } = null!;

    public string? Filtered { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
