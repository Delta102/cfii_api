using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Basic LTI pre-configured activities
/// </summary>
public partial class MdlLtiType
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Baseurl { get; set; } = null!;

    public string Tooldomain { get; set; } = null!;

    public sbyte State { get; set; }

    public long Course { get; set; }

    public bool Coursevisible { get; set; }

    public string Ltiversion { get; set; } = null!;

    public string? Clientid { get; set; }

    public long? Toolproxyid { get; set; }

    public string? Enabledcapability { get; set; }

    public string? Parameter { get; set; }

    public string? Icon { get; set; }

    public string? Secureicon { get; set; }

    public long Createdby { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public string? Description { get; set; }
}
