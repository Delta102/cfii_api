using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// course_modules table retrofitted from MySQL
/// </summary>
public partial class MdlCourseModule
{
    public long Id { get; set; }

    public long Course { get; set; }

    public long Module { get; set; }

    public long Instance { get; set; }

    public long Section { get; set; }

    public string? Idnumber { get; set; }

    public long Added { get; set; }

    public short Score { get; set; }

    public int Indent { get; set; }

    public bool? Visible { get; set; }

    public bool? Visibleoncoursepage { get; set; }

    public bool? Visibleold { get; set; }

    public short Groupmode { get; set; }

    public long Groupingid { get; set; }

    public bool Completion { get; set; }

    public long? Completiongradeitemnumber { get; set; }

    public bool Completionview { get; set; }

    public long Completionexpected { get; set; }

    public bool Showdescription { get; set; }

    public string? Availability { get; set; }

    public bool Deletioninprogress { get; set; }
}
