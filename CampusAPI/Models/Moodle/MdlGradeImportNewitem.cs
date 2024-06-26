using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// temporary table for storing new grade_item names from grade 
/// </summary>
public partial class MdlGradeImportNewitem
{
    public long Id { get; set; }

    public string Itemname { get; set; } = null!;

    public long Importcode { get; set; }

    public long Importer { get; set; }
}
