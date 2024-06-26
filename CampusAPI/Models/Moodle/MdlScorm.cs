using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// each table is one SCORM module and its configuration
/// </summary>
public partial class MdlScorm
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string Scormtype { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string Intro { get; set; } = null!;

    public short Introformat { get; set; }

    public string Version { get; set; } = null!;

    public double Maxgrade { get; set; }

    public sbyte Grademethod { get; set; }

    public long Whatgrade { get; set; }

    public long Maxattempt { get; set; }

    public bool Forcecompleted { get; set; }

    public bool Forcenewattempt { get; set; }

    public bool Lastattemptlock { get; set; }

    public bool? Masteryoverride { get; set; }

    public bool? Displayattemptstatus { get; set; }

    public bool Displaycoursestructure { get; set; }

    public bool Updatefreq { get; set; }

    public string? Sha1hash { get; set; }

    public string Md5hash { get; set; } = null!;

    public long Revision { get; set; }

    public long Launch { get; set; }

    public bool? Skipview { get; set; }

    public bool Hidebrowse { get; set; }

    public bool Hidetoc { get; set; }

    public bool? Nav { get; set; }

    public long? Navpositionleft { get; set; }

    public long? Navpositiontop { get; set; }

    public bool Auto { get; set; }

    public bool Popup { get; set; }

    public string Options { get; set; } = null!;

    public long Width { get; set; }

    public long Height { get; set; }

    public long Timeopen { get; set; }

    public long Timeclose { get; set; }

    public long Timemodified { get; set; }

    public bool? Completionstatusrequired { get; set; }

    public long? Completionscorerequired { get; set; }

    public bool? Completionstatusallscos { get; set; }

    public short Displayactivityname { get; set; }

    public bool Autocommit { get; set; }
}
