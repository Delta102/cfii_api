using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Store files references
/// </summary>
public partial class MdlFilesReference
{
    public long Id { get; set; }

    public long Repositoryid { get; set; }

    public long? Lastsync { get; set; }

    public string? Reference { get; set; }

    public string Referencehash { get; set; } = null!;
}
