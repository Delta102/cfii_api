using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// available options to choice
/// </summary>
public partial class MdlChoiceOption
{
    public long Id { get; set; }

    public long Choiceid { get; set; }

    public string? Text { get; set; }

    public long? Maxanswers { get; set; }

    public long Timemodified { get; set; }
}
