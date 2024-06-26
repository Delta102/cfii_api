using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Details for an oauth 2 connect identity issuer.
/// </summary>
public partial class MdlOauth2Issuer
{
    public long Id { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Usermodified { get; set; }

    public string Name { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Baseurl { get; set; } = null!;

    public string Clientid { get; set; } = null!;

    public string Clientsecret { get; set; } = null!;

    public string Loginscopes { get; set; } = null!;

    public string Loginscopesoffline { get; set; } = null!;

    public string Loginparams { get; set; } = null!;

    public string Loginparamsoffline { get; set; } = null!;

    public string Alloweddomains { get; set; } = null!;

    public string? Scopessupported { get; set; }

    public sbyte Enabled { get; set; }

    public sbyte Showonloginpage { get; set; }

    public sbyte Basicauth { get; set; }

    public long Sortorder { get; set; }

    public sbyte Requireconfirmation { get; set; }

    public string? Servicetype { get; set; }

    public string? Loginpagename { get; set; }
}
