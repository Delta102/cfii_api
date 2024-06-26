using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores PayPal related information
/// </summary>
public partial class MdlPaygwPaypal
{
    public long Id { get; set; }

    public long Paymentid { get; set; }

    public string PpOrderid { get; set; } = null!;
}
