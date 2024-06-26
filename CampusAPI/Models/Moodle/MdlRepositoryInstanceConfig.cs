using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// The config for intances
/// </summary>
public partial class MdlRepositoryInstanceConfig
{
    public long Id { get; set; }

    public long Instanceid { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
