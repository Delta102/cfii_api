using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class Listadocurso
{
    public int Id { get; set; }

    public string Escuela { get; set; } = null!;

    public string Plan { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string Curso { get; set; } = null!;

    public string Ciclo { get; set; } = null!;
}
