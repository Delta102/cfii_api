using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores all members in a conversations
/// </summary>
public partial class MdlMessageConversationMember
{
    public long Id { get; set; }

    public long Conversationid { get; set; }

    public long Userid { get; set; }

    public long Timecreated { get; set; }
}
