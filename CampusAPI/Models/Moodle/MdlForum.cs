using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Forums contain and structure discussion
/// </summary>
public partial class MdlForum
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Intro { get; set; } = null!;

    public short Introformat { get; set; }

    public long Duedate { get; set; }

    public long Cutoffdate { get; set; }

    public long Assessed { get; set; }

    public long Assesstimestart { get; set; }

    public long Assesstimefinish { get; set; }

    public long Scale { get; set; }

    public long GradeForum { get; set; }

    public short GradeForumNotify { get; set; }

    public long Maxbytes { get; set; }

    public long Maxattachments { get; set; }

    public bool Forcesubscribe { get; set; }

    public sbyte Trackingtype { get; set; }

    public sbyte Rsstype { get; set; }

    public sbyte Rssarticles { get; set; }

    public long Timemodified { get; set; }

    public long Warnafter { get; set; }

    public long Blockafter { get; set; }

    public long Blockperiod { get; set; }

    public int Completiondiscussions { get; set; }

    public int Completionreplies { get; set; }

    public int Completionposts { get; set; }

    public bool Displaywordcount { get; set; }

    public long Lockdiscussionafter { get; set; }
}
