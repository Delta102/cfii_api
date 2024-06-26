using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Contains the list of policy documents defined on the site.
/// </summary>
public partial class MdlToolPolicy
{
    public long Id { get; set; }

    public int Sortorder { get; set; }

    public long? Currentversionid { get; set; }
}
