using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Standard log table
/// </summary>
public partial class MdlLogstoreStandardLog
{
    public long Id { get; set; }

    public string Eventname { get; set; } = null!;

    public string Component { get; set; } = null!;

    public string Action { get; set; } = null!;

    public string Target { get; set; } = null!;

    public string? Objecttable { get; set; }

    public long? Objectid { get; set; }

    public string Crud { get; set; } = null!;

    public bool Edulevel { get; set; }

    public long Contextid { get; set; }

    public long Contextlevel { get; set; }

    public long Contextinstanceid { get; set; }

    public long Userid { get; set; }

    public long? Courseid { get; set; }

    public long? Relateduserid { get; set; }

    public bool Anonymous { get; set; }

    public string? Other { get; set; }

    public long Timecreated { get; set; }

    public string? Origin { get; set; }

    public string? Ip { get; set; }

    public long? Realuserid { get; set; }
}
