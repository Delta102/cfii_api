using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlAssignfeedbackEditpdfRot
{
    public long Id { get; set; }

    public long Gradeid { get; set; }

    public long Pageno { get; set; }

    public string Pathnamehash { get; set; } = null!;

    public bool Isrotated { get; set; }

    public long Degree { get; set; }
}
