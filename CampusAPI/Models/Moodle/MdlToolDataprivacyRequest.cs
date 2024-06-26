using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Table for data requests
/// </summary>
public partial class MdlToolDataprivacyRequest
{
    public long Id { get; set; }

    public long Type { get; set; }

    public string? Comments { get; set; }

    public sbyte Commentsformat { get; set; }

    public long Userid { get; set; }

    public long Requestedby { get; set; }

    public sbyte Status { get; set; }

    public long? Dpo { get; set; }

    public string? Dpocomment { get; set; }

    public sbyte Dpocommentformat { get; set; }

    public short Systemapproved { get; set; }

    public long Usermodified { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Creationmethod { get; set; }
}
