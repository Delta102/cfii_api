using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Default comment for the table, please edit me
/// </summary>
public partial class MdlToolDataprivacyCtxexpired
{
    public long Id { get; set; }

    public long Contextid { get; set; }

    public string? Unexpiredroles { get; set; }

    public string? Expiredroles { get; set; }

    public bool Defaultexpired { get; set; }

    public sbyte Status { get; set; }

    public long Usermodified { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
