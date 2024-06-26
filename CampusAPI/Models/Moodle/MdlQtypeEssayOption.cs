using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Extra options for essay questions.
/// </summary>
public partial class MdlQtypeEssayOption
{
    public long Id { get; set; }

    public long Questionid { get; set; }

    public string Responseformat { get; set; } = null!;

    public sbyte Responserequired { get; set; }

    public short Responsefieldlines { get; set; }

    public long? Minwordlimit { get; set; }

    public long? Maxwordlimit { get; set; }

    public short Attachments { get; set; }

    public short Attachmentsrequired { get; set; }

    public string? Graderinfo { get; set; }

    public short Graderinfoformat { get; set; }

    public string? Responsetemplate { get; set; }

    public short Responsetemplateformat { get; set; }

    public long Maxbytes { get; set; }

    public string? Filetypeslist { get; set; }
}
