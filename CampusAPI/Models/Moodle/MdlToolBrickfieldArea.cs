using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Areas that have been checked for accessibility problems
/// </summary>
public partial class MdlToolBrickfieldArea
{
    public long Id { get; set; }

    public sbyte Type { get; set; }

    public long? Contextid { get; set; }

    public string? Component { get; set; }

    public string? Tablename { get; set; }

    public string? Fieldorarea { get; set; }

    public long? Itemid { get; set; }

    public string? Filename { get; set; }

    public string? Reftable { get; set; }

    public long? Refid { get; set; }

    public long? Cmid { get; set; }

    public long? Courseid { get; set; }

    public long? Categoryid { get; set; }
}
