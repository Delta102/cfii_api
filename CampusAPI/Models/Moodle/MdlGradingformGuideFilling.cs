using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the data of how the guide is filled by a particular r
/// </summary>
public partial class MdlGradingformGuideFilling
{
    public long Id { get; set; }

    public long Instanceid { get; set; }

    public long Criterionid { get; set; }

    public string? Remark { get; set; }

    public sbyte? Remarkformat { get; set; }

    public decimal Score { get; set; }
}
