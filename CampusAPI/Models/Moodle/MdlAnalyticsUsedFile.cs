using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Files that have already been used for training and predictio
/// </summary>
public partial class MdlAnalyticsUsedFile
{
    public long Id { get; set; }

    public long Modelid { get; set; }

    public long Fileid { get; set; }

    public string Action { get; set; } = null!;

    public long Time { get; set; }
}
