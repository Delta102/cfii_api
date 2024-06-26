using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the h5pactivity activity module instances.
/// </summary>
public partial class MdlH5pactivity
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public string? Intro { get; set; }

    public short Introformat { get; set; }

    public long? Grade { get; set; }

    public short Displayoptions { get; set; }

    public bool? Enabletracking { get; set; }

    public short Grademethod { get; set; }

    public short? Reviewmode { get; set; }
}
