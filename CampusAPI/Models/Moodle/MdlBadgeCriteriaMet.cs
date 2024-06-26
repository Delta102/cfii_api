using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines criteria that were met for an issued badge
/// </summary>
public partial class MdlBadgeCriteriaMet
{
    public long Id { get; set; }

    public long? Issuedid { get; set; }

    public long Critid { get; set; }

    public long Userid { get; set; }

    public long Datemet { get; set; }
}
