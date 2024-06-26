using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This table saves information about an instance of mod_assign
/// </summary>
public partial class MdlAssign
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string Intro { get; set; } = null!;

    public short Introformat { get; set; }

    public sbyte Alwaysshowdescription { get; set; }

    public sbyte Nosubmissions { get; set; }

    public sbyte Submissiondrafts { get; set; }

    public sbyte Sendnotifications { get; set; }

    public sbyte Sendlatenotifications { get; set; }

    public long Duedate { get; set; }

    public long Allowsubmissionsfromdate { get; set; }

    public long Grade { get; set; }

    public long Timemodified { get; set; }

    public sbyte Requiresubmissionstatement { get; set; }

    public sbyte Completionsubmit { get; set; }

    public long Cutoffdate { get; set; }

    public long Gradingduedate { get; set; }

    public sbyte Teamsubmission { get; set; }

    public sbyte Requireallteammemberssubmit { get; set; }

    public long Teamsubmissiongroupingid { get; set; }

    public sbyte Blindmarking { get; set; }

    public sbyte Hidegrader { get; set; }

    public sbyte Revealidentities { get; set; }

    public string Attemptreopenmethod { get; set; } = null!;

    public int Maxattempts { get; set; }

    public sbyte Markingworkflow { get; set; }

    public sbyte Markingallocation { get; set; }

    public sbyte Sendstudentnotifications { get; set; }

    public sbyte Preventsubmissionnotingroup { get; set; }
}
