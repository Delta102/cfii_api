using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// this defines what role can override what role
/// </summary>
public partial class MdlRoleAllowOverride
{
    public long Id { get; set; }

    public long Roleid { get; set; }

    public long Allowoverride { get; set; }
}
