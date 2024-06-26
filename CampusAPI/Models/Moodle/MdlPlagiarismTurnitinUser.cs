using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Plagiarism Plugin Users
/// </summary>
public partial class MdlPlagiarismTurnitinUser
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long? TurnitinUid { get; set; }

    public long? TurnitinUtp { get; set; }

    public string? InstructorRubrics { get; set; }

    public bool? UserAgreementAccepted { get; set; }
}
