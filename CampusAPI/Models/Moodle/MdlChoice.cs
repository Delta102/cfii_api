using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Available choices are stored here
/// </summary>
public partial class MdlChoice
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string Intro { get; set; } = null!;

    public short Introformat { get; set; }

    public sbyte Publish { get; set; }

    public sbyte Showresults { get; set; }

    public short Display { get; set; }

    public sbyte Allowupdate { get; set; }

    public sbyte Allowmultiple { get; set; }

    public sbyte Showunanswered { get; set; }

    public sbyte Includeinactive { get; set; }

    public sbyte Limitanswers { get; set; }

    public long Timeopen { get; set; }

    public long Timeclose { get; set; }

    public sbyte Showpreview { get; set; }

    public long Timemodified { get; set; }

    public bool Completionsubmit { get; set; }

    public bool Showavailable { get; set; }
}
