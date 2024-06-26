using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Options for multiple choice questions
/// </summary>
public partial class MdlQtypeMultichoiceOption
{
    public long Id { get; set; }

    public long Questionid { get; set; }

    public short Layout { get; set; }

    public short Single { get; set; }

    public short Shuffleanswers { get; set; }

    public string Correctfeedback { get; set; } = null!;

    public sbyte Correctfeedbackformat { get; set; }

    public string Partiallycorrectfeedback { get; set; } = null!;

    public sbyte Partiallycorrectfeedbackformat { get; set; }

    public string Incorrectfeedback { get; set; } = null!;

    public sbyte Incorrectfeedbackformat { get; set; }

    public string Answernumbering { get; set; } = null!;

    public sbyte Shownumcorrect { get; set; }

    public sbyte Showstandardinstruction { get; set; }
}
