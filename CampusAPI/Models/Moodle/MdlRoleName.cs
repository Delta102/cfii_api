using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// role names in native strings
/// </summary>
public partial class MdlRoleName
{
    public long Id { get; set; }

    public long Roleid { get; set; }

    public long Contextid { get; set; }

    public string Name { get; set; } = null!;
}
