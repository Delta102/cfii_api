using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlPayment
{
    public long Id { get; set; }

    public string Component { get; set; } = null!;

    public string Paymentarea { get; set; } = null!;

    public long Itemid { get; set; }

    public long Userid { get; set; }

    public string Amount { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public long Accountid { get; set; }

    public string Gateway { get; set; } = null!;

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
