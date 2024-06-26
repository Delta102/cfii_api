using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// templates of feedbackstructures
/// </summary>
public partial class MdlFeedbackTemplate
{
    public long Id { get; set; }

    public long Course { get; set; }

    public bool Ispublic { get; set; }

    public string Name { get; set; } = null!;
}
