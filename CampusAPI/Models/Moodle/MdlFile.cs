using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// description of files, content is stored in sha1 file pool
/// </summary>
public partial class MdlFile
{
    public long Id { get; set; }

    public string Contenthash { get; set; } = null!;

    public string Pathnamehash { get; set; } = null!;

    public long Contextid { get; set; }

    public string Component { get; set; } = null!;

    public string Filearea { get; set; } = null!;

    public long Itemid { get; set; }

    public string Filepath { get; set; } = null!;

    public string Filename { get; set; } = null!;

    public long? Userid { get; set; }

    public long Filesize { get; set; }

    public string? Mimetype { get; set; }

    public long Status { get; set; }

    public string? Source { get; set; }

    public string? Author { get; set; }

    public string? License { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Sortorder { get; set; }

    public long? Referencefileid { get; set; }
}
