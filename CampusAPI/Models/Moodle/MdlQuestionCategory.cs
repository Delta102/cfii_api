using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Categories are for grouping questions
/// </summary>
public partial class MdlQuestionCategory
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long Contextid { get; set; }

    public string Info { get; set; } = null!;

    public sbyte Infoformat { get; set; }

    public string Stamp { get; set; } = null!;

    public long Parent { get; set; }

    public long Sortorder { get; set; }

    public string? Idnumber { get; set; }
}
