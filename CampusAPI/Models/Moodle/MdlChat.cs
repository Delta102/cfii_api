using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Each of these is a chat room
/// </summary>
public partial class MdlChat
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string Intro { get; set; } = null!;

    public short Introformat { get; set; }

    public long Keepdays { get; set; }

    public short Studentlogs { get; set; }

    public long Chattime { get; set; }

    public short Schedule { get; set; }

    public long Timemodified { get; set; }
}
