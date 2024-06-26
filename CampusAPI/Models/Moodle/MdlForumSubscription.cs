using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Keeps track of who is subscribed to what forum
/// </summary>
public partial class MdlForumSubscription
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Forum { get; set; }
}
