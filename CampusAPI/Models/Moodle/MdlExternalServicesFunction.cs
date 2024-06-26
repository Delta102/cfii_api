using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// lists functions available in each service group
/// </summary>
public partial class MdlExternalServicesFunction
{
    public long Id { get; set; }

    public long Externalserviceid { get; set; }

    public string Functionname { get; set; } = null!;
}
