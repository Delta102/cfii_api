using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class Delegado
{
    public int Id { get; set; }

    public int Aulaid { get; set; }

    public int Moodleuserid { get; set; }

    public int Moodleuserid2 { get; set; }

    public int Estado { get; set; }

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public int? Acreditado { get; set; }

    public DateTime? Fechaacreditacion { get; set; }

    public string? Cursos { get; set; }

    public byte[]? File { get; set; }

    public string? Filename { get; set; }

    public virtual Aula Aula { get; set; } = null!;
}
