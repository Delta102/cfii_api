using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores sections of a quiz with section name (heading), from 
/// </summary>
public partial class MdlQuizSection
{
    public long Id { get; set; }

    public long Quizid { get; set; }

    public long Firstslot { get; set; }

    public string? Heading { get; set; }

    public short Shufflequestions { get; set; }
}
