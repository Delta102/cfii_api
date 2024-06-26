using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlForumGrade
{
    public long Id { get; set; }

    public long Forum { get; set; }

    public long Itemnumber { get; set; }

    public long Userid { get; set; }

    public decimal? Grade { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
