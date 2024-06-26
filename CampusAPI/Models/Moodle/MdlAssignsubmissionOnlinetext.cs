using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Info about onlinetext submission
/// </summary>
public partial class MdlAssignsubmissionOnlinetext
{
    public long Id { get; set; }

    public long Assignment { get; set; }

    public long Submission { get; set; }

    public string? Onlinetext { get; set; }

    public short Onlineformat { get; set; }
}
