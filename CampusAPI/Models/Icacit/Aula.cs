using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class Aula
{
    public int Id { get; set; }

    public int Semestreid { get; set; }

    public int Moodlecourseid { get; set; }

    public int Moodleuserid { get; set; }

    public string Shortname { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public int Estado { get; set; }

    public int? Tipofirma { get; set; }

    public int Restringir { get; set; }

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public virtual ICollection<Curso> Cursos { get; set; } = new List<Curso>();

    public virtual ICollection<Delegado> Delegados { get; set; } = new List<Delegado>();

    public virtual Semestre Semestre { get; set; } = null!;

    public virtual ICollection<Silabo> Silabos { get; set; } = new List<Silabo>();
}
