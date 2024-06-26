using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Link from the consumer to the tool
/// </summary>
public partial class MdlEnrolLtiLti2ResourceLink
{
    public long Id { get; set; }

    public long? Contextid { get; set; }

    public long? Consumerid { get; set; }

    public string Ltiresourcelinkkey { get; set; } = null!;

    public string? Settings { get; set; }

    public long? Primaryresourcelinkid { get; set; }

    public bool? Shareapproved { get; set; }

    public long Created { get; set; }

    public long Updated { get; set; }
}
