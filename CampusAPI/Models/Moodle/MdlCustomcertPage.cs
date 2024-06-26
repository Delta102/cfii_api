using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores each page of a custom cert
/// </summary>
public partial class MdlCustomcertPage
{
    public long Id { get; set; }

    public long Templateid { get; set; }

    public long Width { get; set; }

    public long Height { get; set; }

    public long Leftmargin { get; set; }

    public long Rightmargin { get; set; }

    public long? Sequence { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
