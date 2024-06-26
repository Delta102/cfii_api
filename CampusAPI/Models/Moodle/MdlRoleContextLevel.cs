using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Lists which roles can be assigned at which context levels. T
/// </summary>
public partial class MdlRoleContextLevel
{
    public long Id { get; set; }

    public long Roleid { get; set; }

    public long Contextlevel { get; set; }
}
