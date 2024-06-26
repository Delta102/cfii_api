using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// stores annotations added to pdfs submitted by students
/// </summary>
public partial class MdlAssignfeedbackEditpdfAnnot
{
    public long Id { get; set; }

    public long Gradeid { get; set; }

    public long Pageno { get; set; }

    public long? X { get; set; }

    public long? Y { get; set; }

    public long? Endx { get; set; }

    public long? Endy { get; set; }

    public string? Path { get; set; }

    public string? Type { get; set; }

    public string? Colour { get; set; }

    public sbyte Draft { get; set; }
}
