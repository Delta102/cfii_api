using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class Tutoria
{
    public int Id { get; set; }

    public int Cursoid { get; set; }

    public int Estado { get; set; }

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public virtual Curso Curso { get; set; } = null!;

    public virtual ICollection<TutoriasAlumno> TutoriasAlumnos { get; set; } = new List<TutoriasAlumno>();

    public virtual ICollection<TutoriasSesione> TutoriasSesiones { get; set; } = new List<TutoriasSesione>();
}
