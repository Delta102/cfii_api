using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// search_simpledb table containing the index data.
/// </summary>
public partial class MdlSearchSimpledbIndex
{
    public long Id { get; set; }

    public string Docid { get; set; } = null!;

    public long Itemid { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public long Contextid { get; set; }

    public string Areaid { get; set; } = null!;

    public bool Type { get; set; }

    public long Courseid { get; set; }

    public long? Owneruserid { get; set; }

    public long Modified { get; set; }

    public long? Userid { get; set; }

    public string? Description1 { get; set; }

    public string? Description2 { get; set; }
}
