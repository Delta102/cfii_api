using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Icacit;

public partial class Informefinal
{
    public int Id { get; set; }

    public int Courseid { get; set; }

    public float Cumplimientosilabo { get; set; }

    public int Practicascalificadas { get; set; }

    public int Laboratorios { get; set; }

    public int Proyectoinvestigacion { get; set; }

    public int Matriculados { get; set; }

    public int Aprobados { get; set; }

    public int Desaprobados { get; set; }

    public int Estudiantessnp { get; set; }

    public float Mejornota { get; set; }

    public float Promedionota { get; set; }

    public float Peornota { get; set; }

    /// <summary>
    /// De los estudiantes. Nivel académico, conocimientos previos, interés en el curso, estilos de aprendizaje.
    /// </summary>
    public string Observacion1 { get; set; } = null!;

    /// <summary>
    /// Asistencia y puntualidad de los estudiantes.
    /// </summary>
    public string Observacion2 { get; set; } = null!;

    /// <summary>
    /// Del sílabo. ¿Qué temas del sílabo no se han completado? ¿Considera todos los temas adecuados? ¿Qué temas requieren más tiempo de dedicación?
    /// </summary>
    public string Observacion3 { get; set; } = null!;

    /// <summary>
    /// Mejora continua. ¿Qué actividades de mejora continua ha realizado en el curso en este ciclo? y ¿Cuáles propone para el siguiente, para mejorar el rendimiento académico del estudiante?
    /// </summary>
    public string Observacion4 { get; set; } = null!;

    /// <summary>
    /// Actualización docente. ¿Ha seguido usted algún curso de actualización profesional o docente en los últimos dos años? Indique tema del curso y duración.
    /// </summary>
    public string Observacion5 { get; set; } = null!;

    /// <summary>
    /// Comentarios y Recomendaciones. Serán útiles para mejorar el Plan de Estudios y los servicios que brindan la Escuela, la Facultad y la Universidad.
    /// </summary>
    public string Observacion6 { get; set; } = null!;

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public int? Acreditado { get; set; }

    public DateTime? Fechaacreditacion { get; set; }

    public byte[]? File { get; set; }

    public string? Filename { get; set; }

    public virtual Curso Course { get; set; } = null!;
}
