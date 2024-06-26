using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines book
/// </summary>
public partial class MdlBook
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string? Intro { get; set; }

    public short Introformat { get; set; }

    public short Numbering { get; set; }

    public short Navstyle { get; set; }

    public sbyte Customtitles { get; set; }

    public long Revision { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
