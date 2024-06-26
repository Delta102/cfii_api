using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines assignments
/// </summary>
public partial class MdlAssignment
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string Intro { get; set; } = null!;

    public short Introformat { get; set; }

    public string Assignmenttype { get; set; } = null!;

    public sbyte Resubmit { get; set; }

    public sbyte Preventlate { get; set; }

    public sbyte Emailteachers { get; set; }

    public long? Var1 { get; set; }

    public long? Var2 { get; set; }

    public long? Var3 { get; set; }

    public long? Var4 { get; set; }

    public long? Var5 { get; set; }

    public long Maxbytes { get; set; }

    public long Timedue { get; set; }

    public long Timeavailable { get; set; }

    public long Grade { get; set; }

    public long Timemodified { get; set; }
}
