using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlCustomfieldDatum
{
    public long Id { get; set; }

    public long Fieldid { get; set; }

    public long Instanceid { get; set; }

    public long? Intvalue { get; set; }

    public decimal? Decvalue { get; set; }

    public string? Shortcharvalue { get; set; }

    public string? Charvalue { get; set; }

    public string Value { get; set; } = null!;

    public long Valueformat { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long? Contextid { get; set; }
}
