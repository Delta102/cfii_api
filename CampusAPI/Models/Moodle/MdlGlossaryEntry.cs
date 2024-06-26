using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// all glossary entries
/// </summary>
public partial class MdlGlossaryEntry
{
    public long Id { get; set; }

    public long Glossaryid { get; set; }

    public long Userid { get; set; }

    public string Concept { get; set; } = null!;

    public string Definition { get; set; } = null!;

    public sbyte Definitionformat { get; set; }

    public sbyte Definitiontrust { get; set; }

    public string Attachment { get; set; } = null!;

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public sbyte Teacherentry { get; set; }

    public long Sourceglossaryid { get; set; }

    public sbyte Usedynalink { get; set; }

    public sbyte Casesensitive { get; set; }

    public sbyte Fullmatch { get; set; }

    public sbyte Approved { get; set; }
}
