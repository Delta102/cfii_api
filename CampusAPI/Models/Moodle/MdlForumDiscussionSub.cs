using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Users may choose to subscribe and unsubscribe from specific 
/// </summary>
public partial class MdlForumDiscussionSub
{
    public long Id { get; set; }

    public long Forum { get; set; }

    public long Userid { get; set; }

    public long Discussion { get; set; }

    public long Preference { get; set; }
}
