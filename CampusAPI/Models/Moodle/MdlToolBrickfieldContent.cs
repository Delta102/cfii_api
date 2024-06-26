using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Content of an area at a particular time (recognised by a has
/// </summary>
public partial class MdlToolBrickfieldContent
{
    public long Id { get; set; }

    public long Areaid { get; set; }

    public string Contenthash { get; set; } = null!;

    public bool Iscurrent { get; set; }

    public sbyte Status { get; set; }

    public long Timecreated { get; set; }

    public long? Timechecked { get; set; }
}
