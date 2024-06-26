using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Information about the local and remote hosts for RPC
/// </summary>
public partial class MdlMnetHost
{
    public long Id { get; set; }

    public bool Deleted { get; set; }

    public string Wwwroot { get; set; } = null!;

    public string IpAddress { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string PublicKey { get; set; } = null!;

    public long PublicKeyExpires { get; set; }

    public sbyte Transport { get; set; }

    public int Portno { get; set; }

    public long LastConnectTime { get; set; }

    public long LastLogId { get; set; }

    public bool ForceTheme { get; set; }

    public string? Theme { get; set; }

    public long Applicationid { get; set; }

    public bool Sslverification { get; set; }
}
