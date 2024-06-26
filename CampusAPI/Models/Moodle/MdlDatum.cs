using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// all database activities
/// </summary>
public partial class MdlDatum
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string Intro { get; set; } = null!;

    public short Introformat { get; set; }

    public short Comments { get; set; }

    public long Timeavailablefrom { get; set; }

    public long Timeavailableto { get; set; }

    public long Timeviewfrom { get; set; }

    public long Timeviewto { get; set; }

    public int Requiredentries { get; set; }

    public int Requiredentriestoview { get; set; }

    public int Maxentries { get; set; }

    public short Rssarticles { get; set; }

    public string? Singletemplate { get; set; }

    public string? Listtemplate { get; set; }

    public string? Listtemplateheader { get; set; }

    public string? Listtemplatefooter { get; set; }

    public string? Addtemplate { get; set; }

    public string? Rsstemplate { get; set; }

    public string? Rsstitletemplate { get; set; }

    public string? Csstemplate { get; set; }

    public string? Jstemplate { get; set; }

    public string? Asearchtemplate { get; set; }

    public short Approval { get; set; }

    public short Manageapproved { get; set; }

    public long Scale { get; set; }

    public long Assessed { get; set; }

    public long Assesstimestart { get; set; }

    public long Assesstimefinish { get; set; }

    public long Defaultsort { get; set; }

    public short Defaultsortdir { get; set; }

    public short Editany { get; set; }

    public long Notification { get; set; }

    public long Timemodified { get; set; }

    public string? Config { get; set; }

    public long? Completionentries { get; set; }
}
