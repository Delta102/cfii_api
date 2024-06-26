using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores all the actual chat messages
/// </summary>
public partial class MdlChatMessage
{
    public long Id { get; set; }

    public long Chatid { get; set; }

    public long Userid { get; set; }

    public long Groupid { get; set; }

    public bool Issystem { get; set; }

    public string Message { get; set; } = null!;

    public long Timestamp { get; set; }
}
