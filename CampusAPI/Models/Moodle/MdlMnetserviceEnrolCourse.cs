using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Caches the information fetched via XML-RPC about courses on 
/// </summary>
public partial class MdlMnetserviceEnrolCourse
{
    public long Id { get; set; }

    public long Hostid { get; set; }

    public long Remoteid { get; set; }

    public long Categoryid { get; set; }

    public string Categoryname { get; set; } = null!;

    public long Sortorder { get; set; }

    public string Fullname { get; set; } = null!;

    public string Shortname { get; set; } = null!;

    public string Idnumber { get; set; } = null!;

    public string Summary { get; set; } = null!;

    public short? Summaryformat { get; set; }

    public long Startdate { get; set; }

    public long Roleid { get; set; }

    public string Rolename { get; set; } = null!;
}
