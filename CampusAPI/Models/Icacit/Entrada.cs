using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class Entrada
{
    public int Id { get; set; }

    public int Courseid { get; set; }

    public int Matriculados { get; set; }

    public int Evaluados { get; set; }

    public string Medidascorrectivas { get; set; } = null!;

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public int? Acreditado { get; set; }

    public DateTime? Fechaacreditacion { get; set; }

    public byte[]? File { get; set; }

    public string? Filename { get; set; }

    public virtual Curso Course { get; set; } = null!;

    public virtual ICollection<EntradasDetalle> EntradasDetalles { get; set; } = new List<EntradasDetalle>();
}
