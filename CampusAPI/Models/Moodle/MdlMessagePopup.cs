using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Keep state of notifications for the popup message processor
/// </summary>
public partial class MdlMessagePopup
{
    public long Id { get; set; }

    public long Messageid { get; set; }

    public bool Isread { get; set; }
}
