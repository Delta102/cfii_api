using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines different set of tags
/// </summary>
public partial class MdlTagColl
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public sbyte Isdefault { get; set; }

    public string? Component { get; set; }

    public int Sortorder { get; set; }

    public sbyte Searchable { get; set; }

    public string? Customurl { get; set; }
}
