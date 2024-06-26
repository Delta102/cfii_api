using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Nonce used for authentication between moodle and a consumer
/// </summary>
public partial class MdlEnrolLtiLti2Nonce
{
    public long Id { get; set; }

    public long Consumerid { get; set; }

    public string Value { get; set; } = null!;

    public long Expires { get; set; }
}
