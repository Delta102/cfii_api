using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Setting of the display formats
/// </summary>
public partial class MdlGlossaryFormat
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Popupformatname { get; set; } = null!;

    public sbyte Visible { get; set; }

    public sbyte Showgroup { get; set; }

    public string? Showtabs { get; set; }

    public string Defaultmode { get; set; } = null!;

    public string Defaulthook { get; set; } = null!;

    public string Sortkey { get; set; } = null!;

    public string Sortorder { get; set; } = null!;
}
