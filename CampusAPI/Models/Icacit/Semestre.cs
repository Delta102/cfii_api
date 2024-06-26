using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class Semestre
{
    public int Id { get; set; }

    public string Semestre1 { get; set; } = null!;

    public string? Descripcion { get; set; }

    public long Inicio { get; set; }

    public long Fin { get; set; }

    public string? Categorias { get; set; }

    public string? Cursos { get; set; }

    public int Marcacion { get; set; }

    public int Matriculacion { get; set; }

    public int Estado { get; set; }

    public DateTime Creado { get; set; }

    public long? Modificado { get; set; }

    public virtual ICollection<Aula> Aulas { get; set; } = new List<Aula>();

    public virtual ICollection<Excepcione> Excepciones { get; set; } = new List<Excepcione>();

    public virtual ICollection<Marcacion> Marcacions { get; set; } = new List<Marcacion>();

    public virtual ICollection<Semestredetalle> Semestredetalles { get; set; } = new List<Semestredetalle>();

    public virtual ICollection<SemestresFormato> SemestresFormatos { get; set; } = new List<SemestresFormato>();
}
