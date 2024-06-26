using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Course completion aggregation methods for criteria
/// </summary>
public partial class MdlCourseCompletionAggrMethd
{
    public long Id { get; set; }

    public long Course { get; set; }

    public long? Criteriatype { get; set; }

    public bool Method { get; set; }

    public decimal? Value { get; set; }
}
