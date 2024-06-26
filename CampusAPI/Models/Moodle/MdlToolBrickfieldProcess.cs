using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Queued records to initiate new processing of specific target
/// </summary>
public partial class MdlToolBrickfieldProcess
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public string? Item { get; set; }

    public long? Contextid { get; set; }

    public long? Innercontextid { get; set; }

    public long? Timecreated { get; set; }

    public long? Timecompleted { get; set; }
}
