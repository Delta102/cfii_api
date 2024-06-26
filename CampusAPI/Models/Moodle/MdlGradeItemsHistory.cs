using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// History of grade_items
/// </summary>
public partial class MdlGradeItemsHistory
{
    public long Id { get; set; }

    public long Action { get; set; }

    public long Oldid { get; set; }

    public string? Source { get; set; }

    public long? Timemodified { get; set; }

    public long? Loggeduser { get; set; }

    public long? Courseid { get; set; }

    public long? Categoryid { get; set; }

    public string? Itemname { get; set; }

    public string Itemtype { get; set; } = null!;

    public string? Itemmodule { get; set; }

    public long? Iteminstance { get; set; }

    public long? Itemnumber { get; set; }

    public string? Iteminfo { get; set; }

    public string? Idnumber { get; set; }

    public string? Calculation { get; set; }

    public short Gradetype { get; set; }

    public decimal Grademax { get; set; }

    public decimal Grademin { get; set; }

    public long? Scaleid { get; set; }

    public long? Outcomeid { get; set; }

    public decimal Gradepass { get; set; }

    public decimal Multfactor { get; set; }

    public decimal Plusfactor { get; set; }

    public decimal Aggregationcoef { get; set; }

    public decimal Aggregationcoef2 { get; set; }

    public long Sortorder { get; set; }

    public long Hidden { get; set; }

    public long Locked { get; set; }

    public long Locktime { get; set; }

    public long Needsupdate { get; set; }

    public long Display { get; set; }

    public bool? Decimals { get; set; }

    public bool Weightoverride { get; set; }
}
