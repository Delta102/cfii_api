using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stored details used to get an access token as a system user 
/// </summary>
public partial class MdlOauth2SystemAccount
{
    public long Id { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Usermodified { get; set; }

    public long Issuerid { get; set; }

    public string Refreshtoken { get; set; } = null!;

    public string Grantedscopes { get; set; } = null!;

    public string? Email { get; set; }

    public string Username { get; set; } = null!;
}
