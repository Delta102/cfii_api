using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class TutoriasAlumno
{
    public int Id { get; set; }

    public int Tutoriaid { get; set; }

    public int Moodleuserid { get; set; }

    public string Resolucion { get; set; } = null!;

    public int Estado { get; set; }

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public int? Acreditado { get; set; }

    public DateTime? Fechaacreditacion { get; set; }

    public byte[]? File { get; set; }

    public string? Filename { get; set; }

    public virtual Tutoria Tutoria { get; set; } = null!;

    public virtual ICollection<TutoriasSesione> TutoriasSesiones { get; set; } = new List<TutoriasSesione>();
}
