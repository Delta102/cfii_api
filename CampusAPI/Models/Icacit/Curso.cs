using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class Curso
{
    public int Id { get; set; }

    public int Aulaid { get; set; }

    public string Codcourse { get; set; } = null!;

    public string Escuela { get; set; } = null!;

    public int Plan { get; set; }

    public string Codgrupo { get; set; } = null!;

    public string Nomgrupo { get; set; } = null!;

    public int Estado { get; set; }

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public virtual Aula Aula { get; set; } = null!;

    public virtual ICollection<CriteriosEvaluacion> CriteriosEvaluacions { get; set; } = new List<CriteriosEvaluacion>();

    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();

    public virtual ICollection<Informefinal> Informefinals { get; set; } = new List<Informefinal>();

    public virtual ICollection<Tutoria> Tutoria { get; set; } = new List<Tutoria>();
}
