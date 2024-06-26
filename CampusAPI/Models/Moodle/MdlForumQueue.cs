using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// For keeping track of posts that will be mailed in digest for
/// </summary>
public partial class MdlForumQueue
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Discussionid { get; set; }

    public long Postid { get; set; }

    public long Timemodified { get; set; }
}
