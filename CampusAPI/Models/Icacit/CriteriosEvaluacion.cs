using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class CriteriosEvaluacion
{
    public int Id { get; set; }

    public int Cursoid { get; set; }

    public string? Horario { get; set; }

    public string? Evidencia { get; set; }

    public int Estado { get; set; }

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public virtual ICollection<CriteriosEvaluacionRubica> CriteriosEvaluacionRubicas { get; set; } = new List<CriteriosEvaluacionRubica>();

    public virtual Curso Curso { get; set; } = null!;
}
