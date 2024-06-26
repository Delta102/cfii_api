using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Information about applications on remote hosts
/// </summary>
public partial class MdlMnetApplication
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string XmlrpcServerUrl { get; set; } = null!;

    public string SsoLandUrl { get; set; } = null!;

    public string SsoJumpUrl { get; set; } = null!;
}
