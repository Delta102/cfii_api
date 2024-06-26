using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores all per-user actions on individual messages
/// </summary>
public partial class MdlMessageUserAction
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Messageid { get; set; }

    public long Action { get; set; }

    public long Timecreated { get; set; }
}
