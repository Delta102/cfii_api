using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// table tracking password reset confirmation tokens
/// </summary>
public partial class MdlUserPasswordReset
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Timerequested { get; set; }

    public long Timererequested { get; set; }

    public string Token { get; set; } = null!;
}
