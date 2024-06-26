using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// The subquestions that make up a matching question
/// </summary>
public partial class MdlQtypeMatchSubquestion
{
    public long Id { get; set; }

    public long Questionid { get; set; }

    public string Questiontext { get; set; } = null!;

    public sbyte Questiontextformat { get; set; }

    public string Answertext { get; set; } = null!;
}
