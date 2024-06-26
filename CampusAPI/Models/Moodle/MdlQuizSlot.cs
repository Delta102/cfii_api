using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the question used in a quiz, with the order, and for 
/// </summary>
public partial class MdlQuizSlot
{
    public long Id { get; set; }

    public long Slot { get; set; }

    public long Quizid { get; set; }

    public long Page { get; set; }

    public short Requireprevious { get; set; }

    public long Questionid { get; set; }

    public long? Questioncategoryid { get; set; }

    public short? Includingsubcategories { get; set; }

    public decimal Maxmark { get; set; }
}
