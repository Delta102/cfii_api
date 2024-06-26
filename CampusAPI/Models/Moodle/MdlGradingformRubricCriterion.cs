using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the rows of the rubric grid.
/// </summary>
public partial class MdlGradingformRubricCriterion
{
    public long Id { get; set; }

    public long Definitionid { get; set; }

    public long Sortorder { get; set; }

    public string? Description { get; set; }

    public sbyte? Descriptionformat { get; set; }
}
