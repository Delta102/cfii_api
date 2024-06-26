using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// assigning roles in different context
/// </summary>
public partial class MdlRoleAssignment
{
    public long Id { get; set; }

    public long Roleid { get; set; }

    public long Contextid { get; set; }

    public long Userid { get; set; }

    public long Timemodified { get; set; }

    public long Modifierid { get; set; }

    public string Component { get; set; } = null!;

    public long Itemid { get; set; }

    public long Sortorder { get; set; }
}
