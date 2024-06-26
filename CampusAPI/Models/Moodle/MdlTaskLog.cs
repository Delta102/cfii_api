using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlTaskLog
{
    public long Id { get; set; }

    public short Type { get; set; }

    public string Component { get; set; } = null!;

    public string Classname { get; set; } = null!;

    public long Userid { get; set; }

    public decimal Timestart { get; set; }

    public decimal Timeend { get; set; }

    public long Dbreads { get; set; }

    public long Dbwrites { get; set; }

    public sbyte Result { get; set; }

    public string Output { get; set; } = null!;

    public string? Hostname { get; set; }

    public long? Pid { get; set; }
}
