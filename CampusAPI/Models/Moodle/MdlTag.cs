using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Tag table - this generic table will replace the old &quot;tags&quot; t
/// </summary>
public partial class MdlTag
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Tagcollid { get; set; }

    public string Name { get; set; } = null!;

    public string Rawname { get; set; } = null!;

    public bool Isstandard { get; set; }

    public string? Description { get; set; }

    public sbyte Descriptionformat { get; set; }

    public short? Flag { get; set; }

    public long? Timemodified { get; set; }
}
