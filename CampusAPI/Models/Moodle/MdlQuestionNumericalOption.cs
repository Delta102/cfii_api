using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Options for questions of type numerical This table is also u
/// </summary>
public partial class MdlQuestionNumericalOption
{
    public long Id { get; set; }

    public long Question { get; set; }

    public short Showunits { get; set; }

    public short Unitsleft { get; set; }

    public short Unitgradingtype { get; set; }

    public decimal Unitpenalty { get; set; }
}
