using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Remote news feed information. Contains the news feed id, the
/// </summary>
public partial class MdlBlockRssClient
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public string Title { get; set; } = null!;

    public string Preferredtitle { get; set; } = null!;

    public string Description { get; set; } = null!;

    public sbyte Shared { get; set; }

    public string Url { get; set; } = null!;

    public long Skiptime { get; set; }

    public long Skipuntil { get; set; }
}
