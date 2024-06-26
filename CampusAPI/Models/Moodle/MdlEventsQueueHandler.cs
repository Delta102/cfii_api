using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This is the list of queued handlers for processing. The even
/// </summary>
public partial class MdlEventsQueueHandler
{
    public long Id { get; set; }

    public long Queuedeventid { get; set; }

    public long Handlerid { get; set; }

    public long? Status { get; set; }

    public string? Errormessage { get; set; }

    public long Timemodified { get; set; }
}
