using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the elements for a given page
/// </summary>
public partial class MdlCustomcertElement
{
    public long Id { get; set; }

    public long Pageid { get; set; }

    public string Name { get; set; } = null!;

    public string Element { get; set; } = null!;

    public string? Data { get; set; }

    public string? Font { get; set; }

    public long? Fontsize { get; set; }

    public string? Colour { get; set; }

    public long? Posx { get; set; }

    public long? Posy { get; set; }

    public long? Width { get; set; }

    public short? Refpoint { get; set; }

    public long? Sequence { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
