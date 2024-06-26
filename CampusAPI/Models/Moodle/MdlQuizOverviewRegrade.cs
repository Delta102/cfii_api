using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This table records which question attempts need regrading an
/// </summary>
public partial class MdlQuizOverviewRegrade
{
    public long Id { get; set; }

    public long Questionusageid { get; set; }

    public long Slot { get; set; }

    public decimal? Newfraction { get; set; }

    public decimal? Oldfraction { get; set; }

    public short Regraded { get; set; }

    public long Timemodified { get; set; }
}
