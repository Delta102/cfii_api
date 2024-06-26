using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlPaymentAccount
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Idnumber { get; set; }

    public long Contextid { get; set; }

    public bool Enabled { get; set; }

    public bool Archived { get; set; }

    public long? Timecreated { get; set; }

    public long? Timemodified { get; set; }
}
