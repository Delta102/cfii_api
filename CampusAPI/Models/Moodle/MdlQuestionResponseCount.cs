using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Count for each responses for each try at a question.
/// </summary>
public partial class MdlQuestionResponseCount
{
    public long Id { get; set; }

    public long Analysisid { get; set; }

    public long Try { get; set; }

    public long Rcount { get; set; }
}
