using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Warning configuration
/// </summary>
public partial class MdlAttendanceWarning
{
    public long Id { get; set; }

    public long Idnumber { get; set; }

    public long Warningpercent { get; set; }

    public long Warnafter { get; set; }

    public long Maxwarn { get; set; }

    public short Emailuser { get; set; }

    public string Emailsubject { get; set; } = null!;

    public string Emailcontent { get; set; } = null!;

    public short Emailcontentformat { get; set; }

    public string? Thirdpartyemails { get; set; }
}
