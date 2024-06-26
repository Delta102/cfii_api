using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlContentbankContent
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Contenttype { get; set; } = null!;

    public long Contextid { get; set; }

    public bool? Visibility { get; set; }

    public long? Instanceid { get; set; }

    public string? Configdata { get; set; }

    public long Usercreated { get; set; }

    public long? Usermodified { get; set; }

    public long Timecreated { get; set; }

    public long? Timemodified { get; set; }
}
