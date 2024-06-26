using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// LTI tool proxy registrations
/// </summary>
public partial class MdlLtiToolProxy
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Regurl { get; set; }

    public sbyte State { get; set; }

    public string? Guid { get; set; }

    public string? Secret { get; set; }

    public string? Vendorcode { get; set; }

    public string Capabilityoffered { get; set; } = null!;

    public string Serviceoffered { get; set; } = null!;

    public string? Toolproxy { get; set; }

    public long Createdby { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
