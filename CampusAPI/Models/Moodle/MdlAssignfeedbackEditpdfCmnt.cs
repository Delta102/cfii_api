using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores comments added to pdfs
/// </summary>
public partial class MdlAssignfeedbackEditpdfCmnt
{
    public long Id { get; set; }

    public long Gradeid { get; set; }

    public long? X { get; set; }

    public long? Y { get; set; }

    public long? Width { get; set; }

    public string? Rawtext { get; set; }

    public long Pageno { get; set; }

    public string? Colour { get; set; }

    public sbyte Draft { get; set; }
}
