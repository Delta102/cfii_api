using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// User access log and gradeback data
/// </summary>
public partial class MdlEnrolLtiUser
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Toolid { get; set; }

    public string? Serviceurl { get; set; }

    public string? Sourceid { get; set; }

    public string? Consumerkey { get; set; }

    public string? Consumersecret { get; set; }

    public string? Membershipsurl { get; set; }

    public string? Membershipsid { get; set; }

    public decimal? Lastgrade { get; set; }

    public long? Lastaccess { get; set; }

    public long? Timecreated { get; set; }
}
