using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// list of all external functions
/// </summary>
public partial class MdlExternalFunction
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Classname { get; set; } = null!;

    public string Methodname { get; set; } = null!;

    public string? Classpath { get; set; }

    public string Component { get; set; } = null!;

    public string? Capabilities { get; set; }

    public string? Services { get; set; }
}
