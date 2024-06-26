using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// table to cache results from analysis done in statistics repo
/// </summary>
public partial class MdlQuizStatistic
{
    public long Id { get; set; }

    public string Hashcode { get; set; } = null!;

    public short Whichattempts { get; set; }

    public long Timemodified { get; set; }

    public long Firstattemptscount { get; set; }

    public long Highestattemptscount { get; set; }

    public long Lastattemptscount { get; set; }

    public long Allattemptscount { get; set; }

    public decimal? Firstattemptsavg { get; set; }

    public decimal? Highestattemptsavg { get; set; }

    public decimal? Lastattemptsavg { get; set; }

    public decimal? Allattemptsavg { get; set; }

    public decimal? Median { get; set; }

    public decimal? Standarddeviation { get; set; }

    public decimal? Skewness { get; set; }

    public decimal? Kurtosis { get; set; }

    public decimal? Cic { get; set; }

    public decimal? Errorratio { get; set; }

    public decimal? Standarderror { get; set; }
}
