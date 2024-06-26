using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// this defines what role can assign what role
/// </summary>
public partial class MdlRoleAllowAssign
{
    public long Id { get; set; }

    public long Roleid { get; set; }

    public long Allowassign { get; set; }
}
