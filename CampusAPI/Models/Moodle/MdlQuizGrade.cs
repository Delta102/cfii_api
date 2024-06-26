using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the overall grade for each user on the quiz, based on
/// </summary>
public partial class MdlQuizGrade
{
    public long Id { get; set; }

    public long Quiz { get; set; }

    public long Userid { get; set; }

    public decimal Grade { get; set; }

    public long Timemodified { get; set; }
}
