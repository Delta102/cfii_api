using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlLtiAccessToken
{
    public long Id { get; set; }

    public long Typeid { get; set; }

    public string Scope { get; set; } = null!;

    public string Token { get; set; } = null!;

    public long Validuntil { get; set; }

    public long Timecreated { get; set; }

    public long? Lastaccess { get; set; }
}
