using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Each record is one page and its config data
/// </summary>
public partial class MdlPage
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string? Intro { get; set; }

    public short Introformat { get; set; }

    public string? Content { get; set; }

    public short Contentformat { get; set; }

    public short Legacyfiles { get; set; }

    public long? Legacyfileslast { get; set; }

    public short Display { get; set; }

    public string? Displayoptions { get; set; }

    public long Revision { get; set; }

    public long Timemodified { get; set; }
}
