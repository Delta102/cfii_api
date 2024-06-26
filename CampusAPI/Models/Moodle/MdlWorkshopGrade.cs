using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// How the reviewers filled-up the grading forms, given grades 
/// </summary>
public partial class MdlWorkshopGrade
{
    public long Id { get; set; }

    public long Assessmentid { get; set; }

    public string Strategy { get; set; } = null!;

    public long Dimensionid { get; set; }

    public decimal? Grade { get; set; }

    public string? Peercomment { get; set; }

    public short? Peercommentformat { get; set; }
}
