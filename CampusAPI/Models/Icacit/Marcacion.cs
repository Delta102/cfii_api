using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class Marcacion
{
    public int Id { get; set; }

    public int Semestreid { get; set; }

    public int Moodlecourseid { get; set; }

    public int Moodleuserid { get; set; }

    public DateOnly Fecha { get; set; }

    public TimeOnly Horainicio { get; set; }

    public TimeOnly Horafin { get; set; }

    public TimeOnly? Entrada { get; set; }

    public TimeOnly? Salida { get; set; }

    public int Estado { get; set; }

    public int Visible { get; set; }

    public long? Creado { get; set; }

    public long? Modificado { get; set; }

    public virtual ICollection<MarcacionDetalle> MarcacionDetalles { get; set; } = new List<MarcacionDetalle>();

    public virtual ICollection<MarcacionRecuperacion> MarcacionRecuperacions { get; set; } = new List<MarcacionRecuperacion>();

    public virtual Semestre Semestre { get; set; } = null!;
}
