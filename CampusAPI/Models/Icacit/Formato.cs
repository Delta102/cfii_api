using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class Formato
{
    public int Id { get; set; }

    public string Formato1 { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Version { get; set; } = null!;

    public string Permitidos { get; set; } = null!;

    public string? Indice { get; set; }

    public int Estado { get; set; }

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public virtual ICollection<SemestresFormato> SemestresFormatos { get; set; } = new List<SemestresFormato>();
}
