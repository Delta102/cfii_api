using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// the content introduced in each record/fields
/// </summary>
public partial class MdlDataContent
{
    public long Id { get; set; }

    public long Fieldid { get; set; }

    public long Recordid { get; set; }

    public string? Content { get; set; }

    public string? Content1 { get; set; }

    public string? Content2 { get; set; }

    public string? Content3 { get; set; }

    public string? Content4 { get; set; }
}
