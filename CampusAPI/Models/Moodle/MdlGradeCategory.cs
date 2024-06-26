using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This table keeps information about categories, used for grou
/// </summary>
public partial class MdlGradeCategory
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public long? Parent { get; set; }

    public long Depth { get; set; }

    public string? Path { get; set; }

    public string Fullname { get; set; } = null!;

    public long Aggregation { get; set; }

    public long Keephigh { get; set; }

    public long Droplow { get; set; }

    public bool Aggregateonlygraded { get; set; }

    public bool Aggregateoutcomes { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Hidden { get; set; }
}
