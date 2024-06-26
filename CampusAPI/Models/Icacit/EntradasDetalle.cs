using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class EntradasDetalle
{
    public int Id { get; set; }

    public int Entradaid { get; set; }

    public string Conocimiento { get; set; } = null!;

    public double Deficiente { get; set; }

    public double Suficiente { get; set; }

    public double Excede { get; set; }

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public virtual Entrada Entrada { get; set; } = null!;
}
