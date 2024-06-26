using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlMessageConversationAction
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Conversationid { get; set; }

    public long Action { get; set; }

    public long Timecreated { get; set; }
}
