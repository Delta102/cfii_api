using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Store session data from users migrating to other sites
/// </summary>
public partial class MdlMnetLog
{
    public long Id { get; set; }

    public long Hostid { get; set; }

    public long Remoteid { get; set; }

    public long Time { get; set; }

    public long Userid { get; set; }

    public string Ip { get; set; } = null!;

    public long Course { get; set; }

    public string Coursename { get; set; } = null!;

    public string Module { get; set; } = null!;

    public long Cmid { get; set; }

    public string Action { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Info { get; set; } = null!;
}
