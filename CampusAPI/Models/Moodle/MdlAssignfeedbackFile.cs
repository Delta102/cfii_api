using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores info about the number of files submitted by a student
/// </summary>
public partial class MdlAssignfeedbackFile
{
    public long Id { get; set; }

    public long Assignment { get; set; }

    public long Grade { get; set; }

    public long Numfiles { get; set; }
}
