using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlBadgeExternalBackpack
{
    public long Id { get; set; }

    public string Backpackapiurl { get; set; } = null!;

    public string Backpackweburl { get; set; } = null!;

    public string Apiversion { get; set; } = null!;

    public long Sortorder { get; set; }

    public long? Oauth2Issuerid { get; set; }
}
