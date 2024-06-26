using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Generic post table to hold data blog entries etc in differen
/// </summary>
public partial class MdlPost
{
    public long Id { get; set; }

    public string Module { get; set; } = null!;

    public long Userid { get; set; }

    public long Courseid { get; set; }

    public long Groupid { get; set; }

    public long Moduleid { get; set; }

    public long Coursemoduleid { get; set; }

    public string Subject { get; set; } = null!;

    public string? Summary { get; set; }

    public string? Content { get; set; }

    public string Uniquehash { get; set; } = null!;

    public long Rating { get; set; }

    public long Format { get; set; }

    public sbyte Summaryformat { get; set; }

    public string? Attachment { get; set; }

    public string Publishstate { get; set; } = null!;

    public long Lastmodified { get; set; }

    public long Created { get; set; }

    public long? Usermodified { get; set; }
}
