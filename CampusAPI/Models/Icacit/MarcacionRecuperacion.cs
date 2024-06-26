using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class MarcacionRecuperacion
{
    public int Id { get; set; }

    public int Marcacionid { get; set; }

    public DateOnly Fecha { get; set; }

    public TimeOnly Horainicio { get; set; }

    public TimeOnly Horafin { get; set; }

    public TimeOnly? Entrada { get; set; }

    public TimeOnly? Salida { get; set; }

    public int Modo { get; set; }

    public int Estado { get; set; }

    public long? Creado { get; set; }

    public long? Modificado { get; set; }

    public virtual Marcacion Marcacion { get; set; } = null!;
}
