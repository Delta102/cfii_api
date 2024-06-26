using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Organises and stores properties for dataset items
/// </summary>
public partial class MdlQuestionDatasetDefinition
{
    public long Id { get; set; }

    public long Category { get; set; }

    public string Name { get; set; } = null!;

    public long Type { get; set; }

    public string Options { get; set; } = null!;

    public long Itemcount { get; set; }
}
