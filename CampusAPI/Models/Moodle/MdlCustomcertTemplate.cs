using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores each customcert template
/// </summary>
public partial class MdlCustomcertTemplate
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long Contextid { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
