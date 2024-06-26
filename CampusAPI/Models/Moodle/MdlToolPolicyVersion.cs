using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Holds versions of the policy documents
/// </summary>
public partial class MdlToolPolicyVersion
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public short Type { get; set; }

    public short Audience { get; set; }

    public short Archived { get; set; }

    public long Usermodified { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Policyid { get; set; }

    public short Agreementstyle { get; set; }

    public short Optional { get; set; }

    public string Revision { get; set; } = null!;

    public string Summary { get; set; } = null!;

    public short Summaryformat { get; set; }

    public string Content { get; set; } = null!;

    public short Contentformat { get; set; }
}
