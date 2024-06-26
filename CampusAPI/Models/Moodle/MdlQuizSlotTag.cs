using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores data about the tags that a question must have so that
/// </summary>
public partial class MdlQuizSlotTag
{
    public long Id { get; set; }

    public long? Slotid { get; set; }

    public long? Tagid { get; set; }

    public string? Tagname { get; set; }
}
