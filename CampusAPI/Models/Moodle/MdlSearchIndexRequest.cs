using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Records requests for (re)indexing of specific contexts. Entr
/// </summary>
public partial class MdlSearchIndexRequest
{
    public long Id { get; set; }

    public long Contextid { get; set; }

    public string Searcharea { get; set; } = null!;

    public long Timerequested { get; set; }

    public string Partialarea { get; set; } = null!;

    public long Partialtime { get; set; }

    public long Indexpriority { get; set; }
}
