using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class MarcacionDetalle
{
    public int Id { get; set; }

    public int Marcacionid { get; set; }

    public int Seccion { get; set; }

    public string Tema { get; set; } = null!;

    public float Avance { get; set; }

    public string? Observaciones { get; set; }

    public string? Url { get; set; }

    public byte[]? Imagen { get; set; }

    public int Tolerancia { get; set; }

    public long? Creado { get; set; }

    public long? Modificado { get; set; }

    public virtual Marcacion Marcacion { get; set; } = null!;
}
