using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class TutoriasSesione
{
    public int Id { get; set; }

    public int Tutoriaid { get; set; }

    public int Alumnoid { get; set; }

    public DateOnly Fecha { get; set; }

    public TimeOnly Horainicio { get; set; }

    public TimeOnly Horafin { get; set; }

    public string? Observaciones { get; set; }

    public int? Asistencia { get; set; }

    public DateTime? Firmaalumno { get; set; }

    public int Estado { get; set; }

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public virtual TutoriasAlumno Alumno { get; set; } = null!;

    public virtual Tutoria Tutoria { get; set; } = null!;
}
