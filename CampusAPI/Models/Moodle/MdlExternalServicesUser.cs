using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// users allowed to use services with restricted users flag
/// </summary>
public partial class MdlExternalServicesUser
{
    public long Id { get; set; }

    public long Externalserviceid { get; set; }

    public long Userid { get; set; }

    public string? Iprestriction { get; set; }

    public long? Validuntil { get; set; }

    public long? Timecreated { get; set; }
}
