using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class CriteriosEvaluacionRubica
{
    public int Id { get; set; }

    public int Criterioid { get; set; }

    public int Moodlefileid { get; set; }

    public string? Name { get; set; }

    public int Estado { get; set; }

    public int? Acreditado { get; set; }

    public DateTime? Fechaacreditacion { get; set; }

    public byte[]? File { get; set; }

    public string? Filename { get; set; }

    public virtual CriteriosEvaluacion Criterio { get; set; } = null!;
}
