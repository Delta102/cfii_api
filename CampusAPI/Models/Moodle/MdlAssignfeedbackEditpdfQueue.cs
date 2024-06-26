using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Queue for processing.
/// </summary>
public partial class MdlAssignfeedbackEditpdfQueue
{
    public long Id { get; set; }

    public long Submissionid { get; set; }

    public long Submissionattempt { get; set; }

    public long Attemptedconversions { get; set; }
}
