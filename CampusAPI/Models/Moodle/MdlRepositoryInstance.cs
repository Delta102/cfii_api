using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This table contains one entry for every configured external 
/// </summary>
public partial class MdlRepositoryInstance
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long Typeid { get; set; }

    public long Userid { get; set; }

    public long Contextid { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public long? Timecreated { get; set; }

    public long? Timemodified { get; set; }

    public bool Readonly { get; set; }
}
