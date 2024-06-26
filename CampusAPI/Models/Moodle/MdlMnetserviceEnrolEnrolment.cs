using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Caches the information about enrolments of our local users i
/// </summary>
public partial class MdlMnetserviceEnrolEnrolment
{
    public long Id { get; set; }

    public long Hostid { get; set; }

    public long Userid { get; set; }

    public long Remotecourseid { get; set; }

    public string Rolename { get; set; } = null!;

    public long Enroltime { get; set; }

    public string Enroltype { get; set; } = null!;
}
