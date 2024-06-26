using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines settings for connecting external backpack
/// </summary>
public partial class MdlBadgeBackpack
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public string Email { get; set; } = null!;

    public long Backpackuid { get; set; }

    public bool Autosync { get; set; }

    public string? Password { get; set; }

    public long? Externalbackpackid { get; set; }
}
