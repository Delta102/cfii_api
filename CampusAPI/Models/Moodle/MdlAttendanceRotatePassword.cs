using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlAttendanceRotatePassword
{
    public long Id { get; set; }

    public long Attendanceid { get; set; }

    public string Password { get; set; } = null!;

    public long Expirytime { get; set; }
}
