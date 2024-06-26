using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This file records the grade items created by the LTI Gradebo
/// </summary>
public partial class MdlLtiserviceGradebookservice
{
    public long Id { get; set; }

    public long Gradeitemid { get; set; }

    public long Courseid { get; set; }

    public long? Toolproxyid { get; set; }

    public long? Typeid { get; set; }

    public string? Baseurl { get; set; }

    public long? Ltilinkid { get; set; }

    public string? Tag { get; set; }

    public string? Resourceid { get; set; }
}
