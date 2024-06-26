using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Maintains lists of contacts between users
/// </summary>
public partial class MdlMessageContact
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Contactid { get; set; }

    public long? Timecreated { get; set; }
}
