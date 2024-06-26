using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// feedback_items
/// </summary>
public partial class MdlFeedbackItem
{
    public long Id { get; set; }

    public long Feedback { get; set; }

    public long Template { get; set; }

    public string Name { get; set; } = null!;

    public string Label { get; set; } = null!;

    public string Presentation { get; set; } = null!;

    public string Typ { get; set; } = null!;

    public bool Hasvalue { get; set; }

    public short Position { get; set; }

    public bool Required { get; set; }

    public long Dependitem { get; set; }

    public string Dependvalue { get; set; } = null!;

    public string Options { get; set; } = null!;
}
