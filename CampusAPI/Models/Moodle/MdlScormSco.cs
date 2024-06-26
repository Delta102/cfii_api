using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// each SCO part of the SCORM module
/// </summary>
public partial class MdlScormSco
{
    public long Id { get; set; }

    public long Scorm { get; set; }

    public string Manifest { get; set; } = null!;

    public string Organization { get; set; } = null!;

    public string Parent { get; set; } = null!;

    public string Identifier { get; set; } = null!;

    public string Launch { get; set; } = null!;

    public string Scormtype { get; set; } = null!;

    public string Title { get; set; } = null!;

    public long Sortorder { get; set; }
}
