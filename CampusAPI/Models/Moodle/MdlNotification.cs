using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores all notifications
/// </summary>
public partial class MdlNotification
{
    public long Id { get; set; }

    public long Useridfrom { get; set; }

    public long Useridto { get; set; }

    public string? Subject { get; set; }

    public string? Fullmessage { get; set; }

    public bool Fullmessageformat { get; set; }

    public string? Fullmessagehtml { get; set; }

    public string? Smallmessage { get; set; }

    public string? Component { get; set; }

    public string? Eventtype { get; set; }

    public string? Contexturl { get; set; }

    public string? Contexturlname { get; set; }

    public long? Timeread { get; set; }

    public long Timecreated { get; set; }

    public string? Customdata { get; set; }
}
