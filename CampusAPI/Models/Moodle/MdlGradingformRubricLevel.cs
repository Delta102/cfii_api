using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the columns of the rubric grid.
/// </summary>
public partial class MdlGradingformRubricLevel
{
    public long Id { get; set; }

    public long Criterionid { get; set; }

    public decimal Score { get; set; }

    public string? Definition { get; set; }

    public long? Definitionformat { get; set; }
}
