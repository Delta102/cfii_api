using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Forums are composed of discussions
/// </summary>
public partial class MdlForumDiscussion
{
    public long Id { get; set; }

    public long Course { get; set; }

    public long Forum { get; set; }

    public string Name { get; set; } = null!;

    public long Firstpost { get; set; }

    public long Userid { get; set; }

    public long Groupid { get; set; }

    public bool? Assessed { get; set; }

    public long Timemodified { get; set; }

    public long Usermodified { get; set; }

    public long Timestart { get; set; }

    public long Timeend { get; set; }

    public bool Pinned { get; set; }

    public long Timelocked { get; set; }
}
