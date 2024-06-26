using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// all glossaries
/// </summary>
public partial class MdlGlossary
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string Intro { get; set; } = null!;

    public short Introformat { get; set; }

    public sbyte Allowduplicatedentries { get; set; }

    public string Displayformat { get; set; } = null!;

    public sbyte Mainglossary { get; set; }

    public sbyte Showspecial { get; set; }

    public sbyte Showalphabet { get; set; }

    public sbyte Showall { get; set; }

    public sbyte Allowcomments { get; set; }

    public sbyte Allowprintview { get; set; }

    public sbyte Usedynalink { get; set; }

    public sbyte Defaultapproval { get; set; }

    public string Approvaldisplayformat { get; set; } = null!;

    public sbyte Globalglossary { get; set; }

    public short Entbypage { get; set; }

    public sbyte Editalways { get; set; }

    public sbyte Rsstype { get; set; }

    public sbyte Rssarticles { get; set; }

    public long Assessed { get; set; }

    public long Assesstimestart { get; set; }

    public long Assesstimefinish { get; set; }

    public long Scale { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public int Completionentries { get; set; }
}
