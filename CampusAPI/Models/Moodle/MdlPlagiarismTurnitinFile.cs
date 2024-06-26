using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// info about submitted files
/// </summary>
public partial class MdlPlagiarismTurnitinFile
{
    public long Id { get; set; }

    public long Cm { get; set; }

    public long Userid { get; set; }

    public long? Submitter { get; set; }

    public string Identifier { get; set; } = null!;

    public string? Externalid { get; set; }

    public long? Itemid { get; set; }

    public string? Statuscode { get; set; }

    public long? Similarityscore { get; set; }

    public int Attempt { get; set; }

    public long? Transmatch { get; set; }

    public long? Lastmodified { get; set; }

    public long? Grade { get; set; }

    public string? Submissiontype { get; set; }

    public long? Orcapable { get; set; }

    public long? Errorcode { get; set; }

    public string? Errormsg { get; set; }

    public long? StudentRead { get; set; }

    public bool GmFeedback { get; set; }

    public bool DuedateReportRefresh { get; set; }
}
