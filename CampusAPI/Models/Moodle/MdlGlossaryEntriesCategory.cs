using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// categories of each glossary entry
/// </summary>
public partial class MdlGlossaryEntriesCategory
{
    public long Id { get; set; }

    public long Categoryid { get; set; }

    public long Entryid { get; set; }
}
