using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Tracks each users read posts
/// </summary>
public partial class MdlForumRead
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Forumid { get; set; }

    public long Discussionid { get; set; }

    public long Postid { get; set; }

    public long Firstread { get; set; }

    public long Lastread { get; set; }
}
