using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlBadgeExternalIdentifier
{
    public long Id { get; set; }

    public long Sitebackpackid { get; set; }

    public string Internalid { get; set; } = null!;

    public string Externalid { get; set; } = null!;

    public string Type { get; set; } = null!;
}
