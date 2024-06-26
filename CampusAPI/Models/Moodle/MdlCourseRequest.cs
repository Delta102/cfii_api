using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// course requests
/// </summary>
public partial class MdlCourseRequest
{
    public long Id { get; set; }

    public string Fullname { get; set; } = null!;

    public string Shortname { get; set; } = null!;

    public string Summary { get; set; } = null!;

    public sbyte Summaryformat { get; set; }

    public long Category { get; set; }

    public string Reason { get; set; } = null!;

    public long Requester { get; set; }

    public string Password { get; set; } = null!;
}
