using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines various tag areas, one area is identified by compone
/// </summary>
public partial class MdlTagArea
{
    public long Id { get; set; }

    public string Component { get; set; } = null!;

    public string Itemtype { get; set; } = null!;

    public bool? Enabled { get; set; }

    public long Tagcollid { get; set; }

    public string? Callback { get; set; }

    public string? Callbackfile { get; set; }

    public bool Showstandard { get; set; }

    public bool Multiplecontexts { get; set; }
}
