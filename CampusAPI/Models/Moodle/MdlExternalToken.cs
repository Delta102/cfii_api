using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Security tokens for accessing of external services
/// </summary>
public partial class MdlExternalToken
{
    public long Id { get; set; }

    public string Token { get; set; } = null!;

    public string? Privatetoken { get; set; }

    public short Tokentype { get; set; }

    public long Userid { get; set; }

    public long Externalserviceid { get; set; }

    public string? Sid { get; set; }

    public long Contextid { get; set; }

    public long Creatorid { get; set; }

    public string? Iprestriction { get; set; }

    public long? Validuntil { get; set; }

    public long Timecreated { get; set; }

    public long? Lastaccess { get; set; }
}
