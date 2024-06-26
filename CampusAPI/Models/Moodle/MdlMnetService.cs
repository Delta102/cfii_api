using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// A service is a group of functions
/// </summary>
public partial class MdlMnetService
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Apiversion { get; set; } = null!;

    public bool Offer { get; set; }
}
