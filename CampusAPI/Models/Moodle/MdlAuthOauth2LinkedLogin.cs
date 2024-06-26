using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Accounts linked to a users Moodle account.
/// </summary>
public partial class MdlAuthOauth2LinkedLogin
{
    public long Id { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Usermodified { get; set; }

    public long Userid { get; set; }

    public long Issuerid { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Confirmtoken { get; set; } = null!;

    public long? Confirmtokenexpires { get; set; }
}
