using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the rows of the criteria grid.
/// </summary>
public partial class MdlGradingformGuideCriterion
{
    public long Id { get; set; }

    public long Definitionid { get; set; }

    public long Sortorder { get; set; }

    public string Shortname { get; set; } = null!;

    public string? Description { get; set; }

    public sbyte? Descriptionformat { get; set; }

    public string? Descriptionmarkers { get; set; }

    public sbyte? Descriptionmarkersformat { get; set; }

    public decimal Maxscore { get; set; }
}
