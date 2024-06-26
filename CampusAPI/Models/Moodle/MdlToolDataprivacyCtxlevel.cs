using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Default comment for the table, please edit me
/// </summary>
public partial class MdlToolDataprivacyCtxlevel
{
    public long Id { get; set; }

    public short Contextlevel { get; set; }

    public long? Purposeid { get; set; }

    public long? Categoryid { get; set; }

    public long Usermodified { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
