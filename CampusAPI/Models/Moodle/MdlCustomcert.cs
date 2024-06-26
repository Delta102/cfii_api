using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines customcerts
/// </summary>
public partial class MdlCustomcert
{
    public long Id { get; set; }

    public long Course { get; set; }

    public long Templateid { get; set; }

    public string Name { get; set; } = null!;

    public string? Intro { get; set; }

    public short Introformat { get; set; }

    public long Requiredtime { get; set; }

    public long Verifyany { get; set; }

    public string? Deliveryoption { get; set; }

    public bool Emailstudents { get; set; }

    public bool Emailteachers { get; set; }

    public string? Emailothers { get; set; }

    public string Protection { get; set; } = null!;

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
