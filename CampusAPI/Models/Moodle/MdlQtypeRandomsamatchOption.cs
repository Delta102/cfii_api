using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Info about a random short-answer matching question
/// </summary>
public partial class MdlQtypeRandomsamatchOption
{
    public long Id { get; set; }

    public long Questionid { get; set; }

    public long Choose { get; set; }

    public sbyte Subcats { get; set; }

    public string Correctfeedback { get; set; } = null!;

    public sbyte Correctfeedbackformat { get; set; }

    public string Partiallycorrectfeedback { get; set; } = null!;

    public sbyte Partiallycorrectfeedbackformat { get; set; }

    public string Incorrectfeedback { get; set; } = null!;

    public sbyte Incorrectfeedbackformat { get; set; }

    public sbyte Shownumcorrect { get; set; }
}
