using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Draft text that is auto-saved every 5 seconds while an edito
/// </summary>
public partial class MdlEditorAttoAutosave
{
    public long Id { get; set; }

    public string Elementid { get; set; } = null!;

    public long Contextid { get; set; }

    public string Pagehash { get; set; } = null!;

    public long Userid { get; set; }

    public string Drafttext { get; set; } = null!;

    public long? Draftid { get; set; }

    public string Pageinstance { get; set; } = null!;

    public long Timemodified { get; set; }
}
