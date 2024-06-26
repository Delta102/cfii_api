using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores all messages
/// </summary>
public partial class MdlMessage1
{
    public long Id { get; set; }

    public long Useridfrom { get; set; }

    public long Conversationid { get; set; }

    public string? Subject { get; set; }

    public string? Fullmessage { get; set; }

    public bool Fullmessageformat { get; set; }

    public string? Fullmessagehtml { get; set; }

    public string? Smallmessage { get; set; }

    public long Timecreated { get; set; }

    public string? Customdata { get; set; }

    public sbyte Fullmessagetrust { get; set; }
}
