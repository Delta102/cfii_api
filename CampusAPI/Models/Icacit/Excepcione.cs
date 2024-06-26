using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class Excepcione
{
    public int Id { get; set; }

    public int Semestreid { get; set; }

    public int Tipo { get; set; }

    public string Excepcion { get; set; } = null!;

    public string Parametros { get; set; } = null!;

    public int Createdby { get; set; }

    public long? Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public int Estado { get; set; }

    public virtual Semestre Semestre { get; set; } = null!;
}
