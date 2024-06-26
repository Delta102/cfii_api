using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Describes the named endpoint for an oauth2 service.
/// </summary>
public partial class MdlOauth2Endpoint
{
    public long Id { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Usermodified { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public long Issuerid { get; set; }
}
