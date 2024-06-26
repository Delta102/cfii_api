using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores access tokens for system accounts in order to be able
/// </summary>
public partial class MdlOauth2AccessToken
{
    public long Id { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Usermodified { get; set; }

    public long Issuerid { get; set; }

    public string Token { get; set; } = null!;

    public long Expires { get; set; }

    public string Scope { get; set; } = null!;
}
