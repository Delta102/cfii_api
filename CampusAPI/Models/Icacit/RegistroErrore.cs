using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class RegistroErrore
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Archivo { get; set; } = null!;

    public string Proceso { get; set; } = null!;

    public long Fecha { get; set; }
}
