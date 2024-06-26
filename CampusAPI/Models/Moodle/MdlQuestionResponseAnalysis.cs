using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Analysis of student responses given to questions.
/// </summary>
public partial class MdlQuestionResponseAnalysis
{
    public long Id { get; set; }

    public string Hashcode { get; set; } = null!;

    public string Whichtries { get; set; } = null!;

    public long Timemodified { get; set; }

    public long Questionid { get; set; }

    public long? Variant { get; set; }

    public string Subqid { get; set; } = null!;

    public string? Aid { get; set; }

    public string? Response { get; set; }

    public decimal Credit { get; set; }
}
