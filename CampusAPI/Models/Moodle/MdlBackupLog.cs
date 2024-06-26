using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// To store all the logs from backup and restore operations (by
/// </summary>
public partial class MdlBackupLog
{
    public long Id { get; set; }

    public string Backupid { get; set; } = null!;

    public short Loglevel { get; set; }

    public string Message { get; set; } = null!;

    public long Timecreated { get; set; }
}
