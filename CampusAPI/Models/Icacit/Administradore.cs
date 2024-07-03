namespace CampusAPI.Models.Icacit;

public partial class Administradore
{
    public int Id { get; set; }

    public string Moodleusername { get; set; } = null!;

    public string Escuelas { get; set; } = null!;

    public int Estado { get; set; }

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }
}
