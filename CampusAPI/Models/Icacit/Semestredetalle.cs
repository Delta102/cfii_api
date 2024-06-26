using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class Semestredetalle
{
    public int Id { get; set; }

    public int Semestreid { get; set; }

    public DateTime? Fechadelegados { get; set; }

    public DateTime? Fechaentrada { get; set; }

    public DateTime? Fechafinales { get; set; }

    public DateOnly? Fechasilabos { get; set; }

    public DateOnly? Fechatutorias { get; set; }

    public DateOnly? Fechaestudiantes { get; set; }

    public string Cursostipo { get; set; } = null!;

    public string Tutoriastipo { get; set; } = null!;

    public int Cursosmodo { get; set; }

    public string Codigos { get; set; } = null!;

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public virtual Semestre Semestre { get; set; } = null!;
}
