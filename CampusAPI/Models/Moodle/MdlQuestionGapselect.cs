using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines select missing words questions
/// </summary>
public partial class MdlQuestionGapselect
{
    public long Id { get; set; }

    public long Questionid { get; set; }

    public short Shuffleanswers { get; set; }

    public string Correctfeedback { get; set; } = null!;

    public sbyte Correctfeedbackformat { get; set; }

    public string Partiallycorrectfeedback { get; set; } = null!;

    public sbyte Partiallycorrectfeedbackformat { get; set; }

    public string Incorrectfeedback { get; set; } = null!;

    public sbyte Incorrectfeedbackformat { get; set; }

    public sbyte Shownumcorrect { get; set; }
}
