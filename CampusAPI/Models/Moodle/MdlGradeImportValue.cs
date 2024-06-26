using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Temporary table for importing grades
/// </summary>
public partial class MdlGradeImportValue
{
    public long Id { get; set; }

    public long? Itemid { get; set; }

    public long? Newgradeitem { get; set; }

    public long Userid { get; set; }

    public decimal? Finalgrade { get; set; }

    public string? Feedback { get; set; }

    public long Importcode { get; set; }

    public long? Importer { get; set; }

    public bool? Importonlyfeedback { get; set; }
}
