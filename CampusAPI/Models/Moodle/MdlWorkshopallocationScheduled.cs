using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the allocation settings for the scheduled allocator
/// </summary>
public partial class MdlWorkshopallocationScheduled
{
    public long Id { get; set; }

    public long Workshopid { get; set; }

    public sbyte Enabled { get; set; }

    public long Submissionend { get; set; }

    public long? Timeallocated { get; set; }

    public string? Settings { get; set; }

    public long? Resultstatus { get; set; }

    public string? Resultmessage { get; set; }

    public string? Resultlog { get; set; }
}
