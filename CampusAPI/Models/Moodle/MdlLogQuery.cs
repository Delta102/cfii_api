using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Logged database queries.
/// </summary>
public partial class MdlLogQuery
{
    public long Id { get; set; }

    public int Qtype { get; set; }

    public string Sqltext { get; set; } = null!;

    public string? Sqlparams { get; set; }

    public int Error { get; set; }

    public string? Info { get; set; }

    public string? Backtrace { get; set; }

    public decimal Exectime { get; set; }

    public long Timelogged { get; set; }
}
