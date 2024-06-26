using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores current session
/// </summary>
public partial class MdlChatMessagesCurrent
{
    public long Id { get; set; }

    public long Chatid { get; set; }

    public long Userid { get; set; }

    public long Groupid { get; set; }

    public bool Issystem { get; set; }

    public string Message { get; set; } = null!;

    public long Timestamp { get; set; }
}
