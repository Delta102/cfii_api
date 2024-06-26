using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This table stores user&apos;s mobile devices information in order
/// </summary>
public partial class MdlUserDevice
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public string Appid { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string Platform { get; set; } = null!;

    public string Version { get; set; } = null!;

    public string Pushid { get; set; } = null!;

    public string Uuid { get; set; } = null!;

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
