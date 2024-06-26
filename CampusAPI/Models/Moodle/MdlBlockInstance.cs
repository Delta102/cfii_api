using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This table stores block instances. The type of block this is
/// </summary>
public partial class MdlBlockInstance
{
    public long Id { get; set; }

    public string Blockname { get; set; } = null!;

    public long Parentcontextid { get; set; }

    public short Showinsubcontexts { get; set; }

    public short Requiredbytheme { get; set; }

    public string Pagetypepattern { get; set; } = null!;

    public string? Subpagepattern { get; set; }

    public string Defaultregion { get; set; } = null!;

    public long Defaultweight { get; set; }

    public string? Configdata { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
