using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Functions or methods that we may publish or subscribe to
/// </summary>
public partial class MdlMnetRpc
{
    public long Id { get; set; }

    public string Functionname { get; set; } = null!;

    public string Xmlrpcpath { get; set; } = null!;

    public string Plugintype { get; set; } = null!;

    public string Pluginname { get; set; } = null!;

    public bool Enabled { get; set; }

    public string Help { get; set; } = null!;

    public string Profile { get; set; } = null!;

    public string Filename { get; set; } = null!;

    public string? Classname { get; set; }

    public bool? Static { get; set; }
}
