using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// all feedbacks
/// </summary>
public partial class MdlFeedback
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string Intro { get; set; } = null!;

    public short Introformat { get; set; }

    public bool? Anonymous { get; set; }

    public bool? EmailNotification { get; set; }

    public bool? MultipleSubmit { get; set; }

    public bool? Autonumbering { get; set; }

    public string SiteAfterSubmit { get; set; } = null!;

    public string PageAfterSubmit { get; set; } = null!;

    public sbyte PageAfterSubmitformat { get; set; }

    public bool PublishStats { get; set; }

    public long Timeopen { get; set; }

    public long Timeclose { get; set; }

    public long Timemodified { get; set; }

    public bool Completionsubmit { get; set; }
}
