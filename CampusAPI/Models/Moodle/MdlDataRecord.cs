using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// every record introduced
/// </summary>
public partial class MdlDataRecord
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Groupid { get; set; }

    public long Dataid { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public short Approved { get; set; }
}
