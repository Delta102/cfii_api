using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines book_chapters
/// </summary>
public partial class MdlBookChapter
{
    public long Id { get; set; }

    public long Bookid { get; set; }

    public long Pagenum { get; set; }

    public long Subchapter { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public short Contentformat { get; set; }

    public sbyte Hidden { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public string Importsrc { get; set; } = null!;
}
