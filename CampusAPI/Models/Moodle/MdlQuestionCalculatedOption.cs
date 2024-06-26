using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Options for questions of type calculated
/// </summary>
public partial class MdlQuestionCalculatedOption
{
    public long Id { get; set; }

    public long Question { get; set; }

    public sbyte Synchronize { get; set; }

    public short Single { get; set; }

    public short Shuffleanswers { get; set; }

    public string? Correctfeedback { get; set; }

    public sbyte Correctfeedbackformat { get; set; }

    public string? Partiallycorrectfeedback { get; set; }

    public sbyte Partiallycorrectfeedbackformat { get; set; }

    public string? Incorrectfeedback { get; set; }

    public sbyte Incorrectfeedbackformat { get; set; }

    public string Answernumbering { get; set; } = null!;

    public sbyte Shownumcorrect { get; set; }
}
