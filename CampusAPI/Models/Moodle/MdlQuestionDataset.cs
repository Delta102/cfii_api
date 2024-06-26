using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Many-many relation between questions and dataset definitions
/// </summary>
public partial class MdlQuestionDataset
{
    public long Id { get; set; }

    public long Question { get; set; }

    public long Datasetdefinition { get; set; }
}
