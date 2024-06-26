using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Options for short answer questions
/// </summary>
public partial class MdlQtypeShortanswerOption
{
    public long Id { get; set; }

    public long Questionid { get; set; }

    public sbyte Usecase { get; set; }
}
