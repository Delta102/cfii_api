using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class SemestresFormato
{
    public int Id { get; set; }

    public int Semestreid { get; set; }

    public int Formatoid { get; set; }

    public string Permitidos { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string Version { get; set; } = null!;

    public int Estado { get; set; }

    public long? Apertura { get; set; }

    public long? Cierre { get; set; }

    public string? Exepciones { get; set; }

    public virtual Formato Formato { get; set; } = null!;

    public virtual Semestre Semestre { get; set; } = null!;
}
