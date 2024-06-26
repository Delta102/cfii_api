using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores wiki pages synonyms
/// </summary>
public partial class MdlWikiSynonym
{
    public long Id { get; set; }

    public long Subwikiid { get; set; }

    public long Pageid { get; set; }

    public string Pagesynonym { get; set; } = null!;
}
