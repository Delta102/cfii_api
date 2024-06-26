using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the results of all the profiling runs
/// </summary>
public partial class MdlProfiling
{
    public long Id { get; set; }

    public string Runid { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Data { get; set; } = null!;

    public long Totalexecutiontime { get; set; }

    public long Totalcputime { get; set; }

    public long Totalcalls { get; set; }

    public long Totalmemory { get; set; }

    public sbyte Runreference { get; set; }

    public string Runcomment { get; set; } = null!;

    public long Timecreated { get; set; }
}
