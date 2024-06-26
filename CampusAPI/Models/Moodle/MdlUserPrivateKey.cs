using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// access keys used in cookieless scripts - rss, etc.
/// </summary>
public partial class MdlUserPrivateKey
{
    public long Id { get; set; }

    public string Script { get; set; } = null!;

    public string Value { get; set; } = null!;

    public long Userid { get; set; }

    public long? Instance { get; set; }

    public string? Iprestriction { get; set; }

    public long? Validuntil { get; set; }

    public long? Timecreated { get; set; }
}
