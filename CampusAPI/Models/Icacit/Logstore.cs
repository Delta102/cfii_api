using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class Logstore
{
    public int Id { get; set; }

    public string? Event { get; set; }

    public string Action { get; set; } = null!;

    public string? Objecttable { get; set; }

    public int? Objectid { get; set; }

    public string? Crud { get; set; }

    public int Moodleuserid { get; set; }

    public long? Creado { get; set; }
}
