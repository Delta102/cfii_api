using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// All posts are stored in this table
/// </summary>
public partial class MdlForumPost
{
    public long Id { get; set; }

    public long Discussion { get; set; }

    public long Parent { get; set; }

    public long Userid { get; set; }

    public long Created { get; set; }

    public long Modified { get; set; }

    public sbyte Mailed { get; set; }

    public string Subject { get; set; } = null!;

    public string Message { get; set; } = null!;

    public sbyte Messageformat { get; set; }

    public sbyte Messagetrust { get; set; }

    public string Attachment { get; set; } = null!;

    public short Totalscore { get; set; }

    public long Mailnow { get; set; }

    public long Privatereplyto { get; set; }

    public long? Wordcount { get; set; }

    public long? Charcount { get; set; }

    public bool Deleted { get; set; }
}
