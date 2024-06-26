using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This table is for storing which components requests what typ
/// </summary>
public partial class MdlEventsHandler
{
    public long Id { get; set; }

    public string Eventname { get; set; } = null!;

    public string Component { get; set; } = null!;

    public string Handlerfile { get; set; } = null!;

    public string? Handlerfunction { get; set; }

    public string? Schedule { get; set; }

    public long Status { get; set; }

    public sbyte Internal { get; set; }
}
