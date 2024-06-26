using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Options for True-False questions
/// </summary>
public partial class MdlQuestionTruefalse
{
    public long Id { get; set; }

    public long Question { get; set; }

    public long Trueanswer { get; set; }

    public long Falseanswer { get; set; }
}
