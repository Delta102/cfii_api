using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This table&apos;s main purpose it to assign a unique id to each a
/// </summary>
public partial class MdlQuestionUsage
{
    public long Id { get; set; }

    public long Contextid { get; set; }

    public string Component { get; set; } = null!;

    public string Preferredbehaviour { get; set; } = null!;
}
