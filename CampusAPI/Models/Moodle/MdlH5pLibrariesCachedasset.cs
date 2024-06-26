using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlH5pLibrariesCachedasset
{
    public long Id { get; set; }

    public long Libraryid { get; set; }

    public string Hash { get; set; } = null!;
}
