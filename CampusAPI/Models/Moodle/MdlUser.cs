using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// One record for each person
/// </summary>
public partial class MdlUser
{
    public long Id { get; set; }

    public string Auth { get; set; } = null!;

    public bool Confirmed { get; set; }

    public bool Policyagreed { get; set; }

    public bool Deleted { get; set; }

    public bool Suspended { get; set; }

    public long Mnethostid { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Idnumber { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool Emailstop { get; set; }

    public string Phone1 { get; set; } = null!;

    public string Phone2 { get; set; } = null!;

    public string Institution { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Lang { get; set; } = null!;

    public string Calendartype { get; set; } = null!;

    public string Theme { get; set; } = null!;

    public string Timezone { get; set; } = null!;

    public long Firstaccess { get; set; }

    public long Lastaccess { get; set; }

    public long Lastlogin { get; set; }

    public long Currentlogin { get; set; }

    public string Lastip { get; set; } = null!;

    public string Secret { get; set; } = null!;

    public long Picture { get; set; }

    public string? Description { get; set; }

    public sbyte Descriptionformat { get; set; }

    public bool? Mailformat { get; set; }

    public bool Maildigest { get; set; }

    public sbyte Maildisplay { get; set; }

    public bool? Autosubscribe { get; set; }

    public bool Trackforums { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Trustbitmask { get; set; }

    public string? Imagealt { get; set; }

    public string? Lastnamephonetic { get; set; }

    public string? Firstnamephonetic { get; set; }

    public string? Middlename { get; set; }

    public string? Alternatename { get; set; }

    public string? Moodlenetprofile { get; set; }
}
