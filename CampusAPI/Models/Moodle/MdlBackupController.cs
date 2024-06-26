using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// To store the backup_controllers as they are used
/// </summary>
public partial class MdlBackupController
{
    public long Id { get; set; }

    public string Backupid { get; set; } = null!;

    public string Operation { get; set; } = null!;

    public string Type { get; set; } = null!;

    public long Itemid { get; set; }

    public string Format { get; set; } = null!;

    public short Interactive { get; set; }

    public short Purpose { get; set; }

    public long Userid { get; set; }

    public short Status { get; set; }

    public short Execution { get; set; }

    public long Executiontime { get; set; }

    public string Checksum { get; set; } = null!;

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public decimal Progress { get; set; }

    public string Controller { get; set; } = null!;
}
