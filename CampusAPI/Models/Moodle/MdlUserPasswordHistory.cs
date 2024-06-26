using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// A rotating log of hashes of previously used passwords for ea
/// </summary>
public partial class MdlUserPasswordHistory
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public string Hash { get; set; } = null!;

    public long Timecreated { get; set; }
}
