using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores all message conversations
/// </summary>
public partial class MdlMessageConversation
{
    public long Id { get; set; }

    public long Type { get; set; }

    public string? Name { get; set; }

    public string? Convhash { get; set; }

    public string? Component { get; set; }

    public string? Itemtype { get; set; }

    public long? Itemid { get; set; }

    public long? Contextid { get; set; }

    public bool Enabled { get; set; }

    public long Timecreated { get; set; }

    public long? Timemodified { get; set; }
}
