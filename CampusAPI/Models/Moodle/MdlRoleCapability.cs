using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// permission has to be signed, overriding a capability for a p
/// </summary>
public partial class MdlRoleCapability
{
    public long Id { get; set; }

    public long Contextid { get; set; }

    public long Roleid { get; set; }

    public string Capability { get; set; } = null!;

    public long Permission { get; set; }

    public long Timemodified { get; set; }

    public long Modifierid { get; set; }
}
