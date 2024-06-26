using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// built in and custom external services
/// </summary>
public partial class MdlExternalService
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public bool Enabled { get; set; }

    public string? Requiredcapability { get; set; }

    public bool Restrictedusers { get; set; }

    public string? Component { get; set; }

    public long Timecreated { get; set; }

    public long? Timemodified { get; set; }

    public string? Shortname { get; set; }

    public bool Downloadfiles { get; set; }

    public bool Uploadfiles { get; set; }
}
