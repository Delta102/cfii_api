using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// A list of items in the course recycle bin
/// </summary>
public partial class MdlToolRecyclebinCourse
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public long Section { get; set; }

    public long Module { get; set; }

    public string? Name { get; set; }

    public long Timecreated { get; set; }
}
