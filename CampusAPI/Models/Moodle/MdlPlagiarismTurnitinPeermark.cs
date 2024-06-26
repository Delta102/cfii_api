using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Turnitin Plagiarism Peermark Assignments
/// </summary>
public partial class MdlPlagiarismTurnitinPeermark
{
    public long Id { get; set; }

    public long ParentTiiAssignId { get; set; }

    public string? Title { get; set; }

    public long Tiiassignid { get; set; }

    public long Dtstart { get; set; }

    public long Dtdue { get; set; }

    public long Dtpost { get; set; }

    public long Maxmarks { get; set; }
}
