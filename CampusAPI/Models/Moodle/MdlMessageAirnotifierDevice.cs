using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Store information about the devices registered in Airnotifie
/// </summary>
public partial class MdlMessageAirnotifierDevice
{
    public long Id { get; set; }

    public long Userdeviceid { get; set; }

    public bool? Enable { get; set; }
}
