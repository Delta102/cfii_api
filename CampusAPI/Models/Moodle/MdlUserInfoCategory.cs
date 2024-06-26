using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Customisable fields categories
/// </summary>
public partial class MdlUserInfoCategory
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long Sortorder { get; set; }
}
