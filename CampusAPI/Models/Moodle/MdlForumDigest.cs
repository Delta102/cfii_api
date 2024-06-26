using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Keeps track of user mail delivery preferences for each forum
/// </summary>
public partial class MdlForumDigest
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Forum { get; set; }

    public bool? Maildigest { get; set; }
}
