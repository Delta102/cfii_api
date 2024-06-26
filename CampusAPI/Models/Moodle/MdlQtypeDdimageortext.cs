using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines drag and drop (text or images onto a background imag
/// </summary>
public partial class MdlQtypeDdimageortext
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
