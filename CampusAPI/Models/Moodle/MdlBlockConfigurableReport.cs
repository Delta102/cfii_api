using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// block_configurable_reports table retrofitted from MySQL
/// </summary>
public partial class MdlBlockConfigurableReport
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public long Ownerid { get; set; }

    public short Visible { get; set; }

    public string Name { get; set; } = null!;

    public string? Summary { get; set; }

    public short Summaryformat { get; set; }

    public string Type { get; set; } = null!;

    public short? Pagination { get; set; }

    public string? Components { get; set; }

    public string? Export { get; set; }

    public short? Jsordering { get; set; }

    public short Global { get; set; }

    public long Lastexecutiontime { get; set; }

    public short Cron { get; set; }

    public bool? Remote { get; set; }
}
