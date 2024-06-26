using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Keeps track of which users are in which chat rooms
/// </summary>
public partial class MdlChatUser
{
    public long Id { get; set; }

    public long Chatid { get; set; }

    public long Userid { get; set; }

    public long Groupid { get; set; }

    public string Version { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public long Firstping { get; set; }

    public long Lastping { get; set; }

    public long Lastmessageping { get; set; }

    public string Sid { get; set; } = null!;

    public long Course { get; set; }

    public string Lang { get; set; } = null!;
}
