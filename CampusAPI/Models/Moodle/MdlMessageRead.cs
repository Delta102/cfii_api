using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores all messages that have been read
/// </summary>
public partial class MdlMessageRead
{
    public long Id { get; set; }

    public long Useridfrom { get; set; }

    public long Useridto { get; set; }

    public string? Subject { get; set; }

    public string? Fullmessage { get; set; }

    public short? Fullmessageformat { get; set; }

    public string? Fullmessagehtml { get; set; }

    public string? Smallmessage { get; set; }

    public bool? Notification { get; set; }

    public string? Contexturl { get; set; }

    public string? Contexturlname { get; set; }

    public long Timecreated { get; set; }

    public long Timeread { get; set; }

    public long Timeuserfromdeleted { get; set; }

    public long Timeusertodeleted { get; set; }

    public string? Component { get; set; }

    public string? Eventtype { get; set; }
}
