using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlPaymentGateway
{
    public long Id { get; set; }

    public long Accountid { get; set; }

    public string Gateway { get; set; } = null!;

    public bool? Enabled { get; set; }

    public string? Config { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
