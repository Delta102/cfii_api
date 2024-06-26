using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Table that maps the published tool to tool consumers.
/// </summary>
public partial class MdlEnrolLtiToolConsumerMap
{
    public long Id { get; set; }

    public long Toolid { get; set; }

    public long Consumerid { get; set; }
}
