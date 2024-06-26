using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class Firmasholografica
{
    public int Id { get; set; }

    public int Moodleuserid { get; set; }

    public byte[] Firma { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }
}
