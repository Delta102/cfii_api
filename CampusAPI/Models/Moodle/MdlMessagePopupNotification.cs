using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// List of notifications to display in the message output popup
/// </summary>
public partial class MdlMessagePopupNotification
{
    public long Id { get; set; }

    public long Notificationid { get; set; }
}
