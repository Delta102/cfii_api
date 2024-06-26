using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace CampusAPI.Models.Icacit;

public partial class IcacitDBContext : DbContext
{
    public IcacitDBContext()
    {
    }

    public IcacitDBContext(DbContextOptions<IcacitDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administradore> Administradores { get; set; }

    public virtual DbSet<Aula> Aulas { get; set; }

    public virtual DbSet<CriteriosEvaluacion> CriteriosEvaluacions { get; set; }

    public virtual DbSet<CriteriosEvaluacionRubica> CriteriosEvaluacionRubicas { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Delegado> Delegados { get; set; }

    public virtual DbSet<Entrada> Entradas { get; set; }

    public virtual DbSet<EntradasDetalle> EntradasDetalles { get; set; }

    public virtual DbSet<Excepcione> Excepciones { get; set; }

    public virtual DbSet<Firmasholografica> Firmasholograficas { get; set; }

    public virtual DbSet<Formato> Formatos { get; set; }

    public virtual DbSet<Informefinal> Informefinals { get; set; }

    public virtual DbSet<Listadocurso> Listadocursos { get; set; }

    public virtual DbSet<Logstore> Logstores { get; set; }

    public virtual DbSet<Marcacion> Marcacions { get; set; }

    public virtual DbSet<MarcacionDetalle> MarcacionDetalles { get; set; }

    public virtual DbSet<MarcacionRecuperacion> MarcacionRecuperacions { get; set; }

    public virtual DbSet<RegistroErrore> RegistroErrores { get; set; }

    public virtual DbSet<Semestre> Semestres { get; set; }

    public virtual DbSet<Semestredetalle> Semestredetalles { get; set; }

    public virtual DbSet<SemestresFormato> SemestresFormatos { get; set; }

    public virtual DbSet<Silabo> Silabos { get; set; }

    public virtual DbSet<Tutoria> Tutorias { get; set; }

    public virtual DbSet<TutoriasAlumno> TutoriasAlumnos { get; set; }

    public virtual DbSet<TutoriasSesione> TutoriasSesiones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=ICACIT;user=root;password=2805", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.37-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Administradore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("administradores")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.Escuelas)
                .HasColumnType("text")
                .HasColumnName("escuelas");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("'1'")
                .HasColumnName("estado");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");
            entity.Property(e => e.Moodleusername)
                .HasColumnType("text")
                .HasColumnName("moodleusername");
        });

        modelBuilder.Entity<Aula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("aulas")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Semestreid, "semestreid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("'1'")
                .HasColumnName("estado");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");
            entity.Property(e => e.Moodlecourseid).HasColumnName("moodlecourseid");
            entity.Property(e => e.Moodleuserid).HasColumnName("moodleuserid");
            entity.Property(e => e.Restringir).HasColumnName("restringir");
            entity.Property(e => e.Semestreid).HasColumnName("semestreid");
            entity.Property(e => e.Shortname)
                .HasColumnType("text")
                .HasColumnName("shortname");
            entity.Property(e => e.Tipo)
                .HasColumnType("text")
                .HasColumnName("tipo");
            entity.Property(e => e.Tipofirma).HasColumnName("tipofirma");

            entity.HasOne(d => d.Semestre).WithMany(p => p.Aulas)
                .HasForeignKey(d => d.Semestreid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("aulas_ibfk_1");
        });

        modelBuilder.Entity<CriteriosEvaluacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("criterios_evaluacion")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Cursoid, "cursoid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.Cursoid).HasColumnName("cursoid");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("'1'")
                .HasColumnName("estado");
            entity.Property(e => e.Evidencia)
                .HasColumnType("text")
                .HasColumnName("evidencia");
            entity.Property(e => e.Horario)
                .HasColumnType("text")
                .HasColumnName("horario");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");

            entity.HasOne(d => d.Curso).WithMany(p => p.CriteriosEvaluacions)
                .HasForeignKey(d => d.Cursoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("criterios_evaluacion_ibfk_1");
        });

        modelBuilder.Entity<CriteriosEvaluacionRubica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("criterios_evaluacion_rubicas")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Criterioid, "criterioid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acreditado).HasColumnName("acreditado");
            entity.Property(e => e.Criterioid).HasColumnName("criterioid");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("'1'")
                .HasColumnName("estado");
            entity.Property(e => e.Fechaacreditacion)
                .HasColumnType("datetime")
                .HasColumnName("fechaacreditacion");
            entity.Property(e => e.File)
                .HasColumnType("mediumblob")
                .HasColumnName("file");
            entity.Property(e => e.Filename)
                .HasColumnType("text")
                .HasColumnName("filename");
            entity.Property(e => e.Moodlefileid).HasColumnName("moodlefileid");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");

            entity.HasOne(d => d.Criterio).WithMany(p => p.CriteriosEvaluacionRubicas)
                .HasForeignKey(d => d.Criterioid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("criterios_evaluacion_rubicas_ibfk_1");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("cursos")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Aulaid, "aulaid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aulaid).HasColumnName("aulaid");
            entity.Property(e => e.Codcourse)
                .HasColumnType("text")
                .HasColumnName("codcourse");
            entity.Property(e => e.Codgrupo)
                .HasColumnType("text")
                .HasColumnName("codgrupo");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.Escuela)
                .HasColumnType("text")
                .HasColumnName("escuela");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("'1'")
                .HasColumnName("estado");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");
            entity.Property(e => e.Nomgrupo)
                .HasColumnType("text")
                .HasColumnName("nomgrupo");
            entity.Property(e => e.Plan).HasColumnName("plan");

            entity.HasOne(d => d.Aula).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.Aulaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cursos_ibfk_1");
        });

        modelBuilder.Entity<Delegado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("delegados")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Aulaid, "aulaid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acreditado).HasColumnName("acreditado");
            entity.Property(e => e.Aulaid).HasColumnName("aulaid");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.Cursos)
                .HasColumnType("text")
                .HasColumnName("cursos");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("'1'")
                .HasColumnName("estado");
            entity.Property(e => e.Fechaacreditacion)
                .HasColumnType("datetime")
                .HasColumnName("fechaacreditacion");
            entity.Property(e => e.File)
                .HasColumnType("mediumblob")
                .HasColumnName("file");
            entity.Property(e => e.Filename)
                .HasColumnType("text")
                .HasColumnName("filename");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");
            entity.Property(e => e.Moodleuserid).HasColumnName("moodleuserid");
            entity.Property(e => e.Moodleuserid2).HasColumnName("moodleuserid2");

            entity.HasOne(d => d.Aula).WithMany(p => p.Delegados)
                .HasForeignKey(d => d.Aulaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("delegados_ibfk_1");
        });

        modelBuilder.Entity<Entrada>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("entradas")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "courseid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acreditado).HasColumnName("acreditado");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.Evaluados).HasColumnName("evaluados");
            entity.Property(e => e.Fechaacreditacion)
                .HasColumnType("datetime")
                .HasColumnName("fechaacreditacion");
            entity.Property(e => e.File)
                .HasColumnType("mediumblob")
                .HasColumnName("file");
            entity.Property(e => e.Filename)
                .HasColumnType("text")
                .HasColumnName("filename");
            entity.Property(e => e.Matriculados).HasColumnName("matriculados");
            entity.Property(e => e.Medidascorrectivas)
                .HasColumnType("text")
                .HasColumnName("medidascorrectivas");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");

            entity.HasOne(d => d.Course).WithMany(p => p.Entrada)
                .HasForeignKey(d => d.Courseid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("entradas_ibfk_1");
        });

        modelBuilder.Entity<EntradasDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("entradas_detalles")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Entradaid, "entradaid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Conocimiento)
                .HasColumnType("text")
                .HasColumnName("conocimiento");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.Deficiente).HasColumnName("deficiente");
            entity.Property(e => e.Entradaid).HasColumnName("entradaid");
            entity.Property(e => e.Excede).HasColumnName("excede");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");
            entity.Property(e => e.Suficiente).HasColumnName("suficiente");

            entity.HasOne(d => d.Entrada).WithMany(p => p.EntradasDetalles)
                .HasForeignKey(d => d.Entradaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("entradas_detalles_ibfk_1");
        });

        modelBuilder.Entity<Excepcione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("excepciones")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Semestreid, "semestreid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Creado).HasColumnName("creado");
            entity.Property(e => e.Createdby)
                .HasDefaultValueSql("'4041'")
                .HasColumnName("createdby");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("'1'")
                .HasColumnName("estado");
            entity.Property(e => e.Excepcion)
                .HasColumnType("text")
                .HasColumnName("excepcion");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");
            entity.Property(e => e.Parametros)
                .HasColumnType("text")
                .HasColumnName("parametros")
                .UseCollation("utf8mb4_0900_ai_ci");
            entity.Property(e => e.Semestreid).HasColumnName("semestreid");
            entity.Property(e => e.Tipo).HasColumnName("tipo");

            entity.HasOne(d => d.Semestre).WithMany(p => p.Excepciones)
                .HasForeignKey(d => d.Semestreid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("excepciones_ibfk_1");
        });

        modelBuilder.Entity<Firmasholografica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("firmasholograficas")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Moodleuserid, "moodleuserid").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.Firma)
                .HasColumnType("mediumblob")
                .HasColumnName("firma");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");
            entity.Property(e => e.Moodleuserid).HasColumnName("moodleuserid");
            entity.Property(e => e.Tipo)
                .HasColumnType("text")
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Formato>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("formatos")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigo)
                .HasColumnType("text")
                .HasColumnName("codigo");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("'1'")
                .HasColumnName("estado");
            entity.Property(e => e.Formato1)
                .HasColumnType("text")
                .HasColumnName("formato");
            entity.Property(e => e.Indice)
                .HasColumnType("text")
                .HasColumnName("indice");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");
            entity.Property(e => e.Permitidos)
                .HasColumnType("text")
                .HasColumnName("permitidos");
            entity.Property(e => e.Version)
                .HasColumnType("text")
                .HasColumnName("version");
        });

        modelBuilder.Entity<Informefinal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("informefinal")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "courseid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acreditado).HasColumnName("acreditado");
            entity.Property(e => e.Aprobados).HasColumnName("aprobados");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.Cumplimientosilabo).HasColumnName("cumplimientosilabo");
            entity.Property(e => e.Desaprobados).HasColumnName("desaprobados");
            entity.Property(e => e.Estudiantessnp).HasColumnName("estudiantessnp");
            entity.Property(e => e.Fechaacreditacion)
                .HasColumnType("datetime")
                .HasColumnName("fechaacreditacion");
            entity.Property(e => e.File)
                .HasColumnType("mediumblob")
                .HasColumnName("file");
            entity.Property(e => e.Filename)
                .HasColumnType("text")
                .HasColumnName("filename");
            entity.Property(e => e.Laboratorios).HasColumnName("laboratorios");
            entity.Property(e => e.Matriculados).HasColumnName("matriculados");
            entity.Property(e => e.Mejornota).HasColumnName("mejornota");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");
            entity.Property(e => e.Observacion1)
                .HasComment("De los estudiantes. Nivel académico, conocimientos previos, interés en el curso, estilos de aprendizaje.")
                .HasColumnType("text")
                .HasColumnName("observacion1");
            entity.Property(e => e.Observacion2)
                .HasComment("Asistencia y puntualidad de los estudiantes.")
                .HasColumnType("text")
                .HasColumnName("observacion2");
            entity.Property(e => e.Observacion3)
                .HasComment("Del sílabo. ¿Qué temas del sílabo no se han completado? ¿Considera todos los temas adecuados? ¿Qué temas requieren más tiempo de dedicación?")
                .HasColumnType("text")
                .HasColumnName("observacion3");
            entity.Property(e => e.Observacion4)
                .HasComment("Mejora continua. ¿Qué actividades de mejora continua ha realizado en el curso en este ciclo? y ¿Cuáles propone para el siguiente, para mejorar el rendimiento académico del estudiante?")
                .HasColumnType("text")
                .HasColumnName("observacion4");
            entity.Property(e => e.Observacion5)
                .HasComment("Actualización docente. ¿Ha seguido usted algún curso de actualización profesional o docente en los últimos dos años? Indique tema del curso y duración.")
                .HasColumnType("text")
                .HasColumnName("observacion5");
            entity.Property(e => e.Observacion6)
                .HasComment("Comentarios y Recomendaciones. Serán útiles para mejorar el Plan de Estudios y los servicios que brindan la Escuela, la Facultad y la Universidad.")
                .HasColumnType("text")
                .HasColumnName("observacion6");
            entity.Property(e => e.Peornota).HasColumnName("peornota");
            entity.Property(e => e.Practicascalificadas).HasColumnName("practicascalificadas");
            entity.Property(e => e.Promedionota).HasColumnName("promedionota");
            entity.Property(e => e.Proyectoinvestigacion).HasColumnName("proyectoinvestigacion");

            entity.HasOne(d => d.Course).WithMany(p => p.Informefinals)
                .HasForeignKey(d => d.Courseid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("informefinal_ibfk_1");
        });

        modelBuilder.Entity<Listadocurso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("listadocursos")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ciclo)
                .HasColumnType("text")
                .HasColumnName("ciclo");
            entity.Property(e => e.Codigo)
                .HasColumnType("text")
                .HasColumnName("codigo");
            entity.Property(e => e.Curso)
                .HasColumnType("text")
                .HasColumnName("curso");
            entity.Property(e => e.Escuela)
                .HasColumnType("text")
                .HasColumnName("escuela");
            entity.Property(e => e.Plan)
                .HasColumnType("text")
                .HasColumnName("plan");
        });

        modelBuilder.Entity<Logstore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logstore")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasColumnType("text")
                .HasColumnName("action");
            entity.Property(e => e.Creado).HasColumnName("creado");
            entity.Property(e => e.Crud)
                .HasMaxLength(1)
                .HasColumnName("crud");
            entity.Property(e => e.Event)
                .HasColumnType("text")
                .HasColumnName("event");
            entity.Property(e => e.Moodleuserid).HasColumnName("moodleuserid");
            entity.Property(e => e.Objectid).HasColumnName("objectid");
            entity.Property(e => e.Objecttable)
                .HasColumnType("text")
                .HasColumnName("objecttable");
        });

        modelBuilder.Entity<Marcacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("marcacion")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Fecha, "marcacion_reporte");

            entity.HasIndex(e => e.Semestreid, "semestreid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Creado).HasColumnName("creado");
            entity.Property(e => e.Entrada)
                .HasColumnType("time")
                .HasColumnName("entrada");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Horafin)
                .HasColumnType("time")
                .HasColumnName("horafin");
            entity.Property(e => e.Horainicio)
                .HasColumnType("time")
                .HasColumnName("horainicio");
            entity.Property(e => e.Modificado).HasColumnName("modificado");
            entity.Property(e => e.Moodlecourseid).HasColumnName("moodlecourseid");
            entity.Property(e => e.Moodleuserid).HasColumnName("moodleuserid");
            entity.Property(e => e.Salida)
                .HasColumnType("time")
                .HasColumnName("salida");
            entity.Property(e => e.Semestreid).HasColumnName("semestreid");
            entity.Property(e => e.Visible)
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");

            entity.HasOne(d => d.Semestre).WithMany(p => p.Marcacions)
                .HasForeignKey(d => d.Semestreid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("marcacion_ibfk_1");
        });

        modelBuilder.Entity<MarcacionDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("marcacion_detalles")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Marcacionid, "marcacion_detalles_reporte");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Avance).HasColumnName("avance");
            entity.Property(e => e.Creado).HasColumnName("creado");
            entity.Property(e => e.Imagen)
                .HasColumnType("mediumblob")
                .HasColumnName("imagen");
            entity.Property(e => e.Marcacionid).HasColumnName("marcacionid");
            entity.Property(e => e.Modificado).HasColumnName("modificado");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
            entity.Property(e => e.Seccion).HasColumnName("seccion");
            entity.Property(e => e.Tema)
                .HasColumnType("text")
                .HasColumnName("tema");
            entity.Property(e => e.Tolerancia)
                .HasDefaultValueSql("'7'")
                .HasColumnName("tolerancia");
            entity.Property(e => e.Url)
                .HasColumnType("text")
                .HasColumnName("url");

            entity.HasOne(d => d.Marcacion).WithMany(p => p.MarcacionDetalles)
                .HasForeignKey(d => d.Marcacionid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("marcacion_detalles_ibfk_1");
        });

        modelBuilder.Entity<MarcacionRecuperacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("marcacion_recuperacion")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Marcacionid, "marcacion_recuperacion_reporte");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Creado).HasColumnName("creado");
            entity.Property(e => e.Entrada)
                .HasColumnType("time")
                .HasColumnName("entrada");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Horafin)
                .HasColumnType("time")
                .HasColumnName("horafin");
            entity.Property(e => e.Horainicio)
                .HasColumnType("time")
                .HasColumnName("horainicio");
            entity.Property(e => e.Marcacionid).HasColumnName("marcacionid");
            entity.Property(e => e.Modificado).HasColumnName("modificado");
            entity.Property(e => e.Modo)
                .HasDefaultValueSql("'1'")
                .HasColumnName("modo");
            entity.Property(e => e.Salida)
                .HasColumnType("time")
                .HasColumnName("salida");

            entity.HasOne(d => d.Marcacion).WithMany(p => p.MarcacionRecuperacions)
                .HasForeignKey(d => d.Marcacionid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("marcacion_recuperacion_ibfk_1");
        });

        modelBuilder.Entity<RegistroErrore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("registro_errores")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Archivo)
                .HasColumnType("text")
                .HasColumnName("archivo");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Proceso)
                .HasColumnType("text")
                .HasColumnName("proceso");
            entity.Property(e => e.Usuario)
                .HasColumnType("text")
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<Semestre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("semestres")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categorias)
                .HasColumnType("text")
                .HasColumnName("categorias");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.Cursos)
                .HasColumnType("text")
                .HasColumnName("cursos");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("'1'")
                .HasColumnName("estado");
            entity.Property(e => e.Fin).HasColumnName("fin");
            entity.Property(e => e.Inicio).HasColumnName("inicio");
            entity.Property(e => e.Marcacion)
                .HasDefaultValueSql("'1'")
                .HasColumnName("marcacion");
            entity.Property(e => e.Matriculacion)
                .HasDefaultValueSql("'1'")
                .HasColumnName("matriculacion");
            entity.Property(e => e.Modificado).HasColumnName("modificado");
            entity.Property(e => e.Semestre1)
                .HasColumnType("text")
                .HasColumnName("semestre");
        });

        modelBuilder.Entity<Semestredetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("semestredetalles")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Semestreid, "semestreid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigos)
                .HasColumnType("text")
                .HasColumnName("codigos");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.Cursosmodo).HasColumnName("cursosmodo");
            entity.Property(e => e.Cursostipo)
                .HasColumnType("text")
                .HasColumnName("cursostipo");
            entity.Property(e => e.Fechadelegados)
                .HasColumnType("datetime")
                .HasColumnName("fechadelegados");
            entity.Property(e => e.Fechaentrada)
                .HasColumnType("datetime")
                .HasColumnName("fechaentrada");
            entity.Property(e => e.Fechaestudiantes).HasColumnName("fechaestudiantes");
            entity.Property(e => e.Fechafinales)
                .HasColumnType("datetime")
                .HasColumnName("fechafinales");
            entity.Property(e => e.Fechasilabos).HasColumnName("fechasilabos");
            entity.Property(e => e.Fechatutorias).HasColumnName("fechatutorias");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");
            entity.Property(e => e.Semestreid).HasColumnName("semestreid");
            entity.Property(e => e.Tutoriastipo)
                .HasColumnType("text")
                .HasColumnName("tutoriastipo");

            entity.HasOne(d => d.Semestre).WithMany(p => p.Semestredetalles)
                .HasForeignKey(d => d.Semestreid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("semestredetalles_ibfk_1");
        });

        modelBuilder.Entity<SemestresFormato>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("semestres_formatos")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Formatoid, "formatoid");

            entity.HasIndex(e => e.Semestreid, "semestreid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apertura).HasColumnName("apertura");
            entity.Property(e => e.Cierre).HasColumnName("cierre");
            entity.Property(e => e.Codigo)
                .HasColumnType("text")
                .HasColumnName("codigo");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("'1'")
                .HasColumnName("estado");
            entity.Property(e => e.Exepciones)
                .HasColumnType("text")
                .HasColumnName("exepciones");
            entity.Property(e => e.Formatoid).HasColumnName("formatoid");
            entity.Property(e => e.Permitidos)
                .HasColumnType("text")
                .HasColumnName("permitidos");
            entity.Property(e => e.Semestreid).HasColumnName("semestreid");
            entity.Property(e => e.Version)
                .HasColumnType("text")
                .HasColumnName("version");

            entity.HasOne(d => d.Formato).WithMany(p => p.SemestresFormatos)
                .HasForeignKey(d => d.Formatoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("semestres_formatos_ibfk_1");

            entity.HasOne(d => d.Semestre).WithMany(p => p.SemestresFormatos)
                .HasForeignKey(d => d.Semestreid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("semestres_formatos_ibfk_2");
        });

        modelBuilder.Entity<Silabo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("silabos")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Aulaid, "aulaid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acreditado).HasColumnName("acreditado");
            entity.Property(e => e.Aulaid).HasColumnName("aulaid");
            entity.Property(e => e.Cursos)
                .HasColumnType("text")
                .HasColumnName("cursos");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("'1'")
                .HasColumnName("estado");
            entity.Property(e => e.Fechaacreditacion)
                .HasColumnType("datetime")
                .HasColumnName("fechaacreditacion");
            entity.Property(e => e.File)
                .HasColumnType("mediumblob")
                .HasColumnName("file");
            entity.Property(e => e.Filename)
                .HasColumnType("text")
                .HasColumnName("filename");
            entity.Property(e => e.Moodlefileid).HasColumnName("moodlefileid");

            entity.HasOne(d => d.Aula).WithMany(p => p.Silabos)
                .HasForeignKey(d => d.Aulaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("silabos_ibfk_1");
        });

        modelBuilder.Entity<Tutoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("tutorias")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Cursoid, "cursoid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.Cursoid).HasColumnName("cursoid");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("'1'")
                .HasColumnName("estado");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");

            entity.HasOne(d => d.Curso).WithMany(p => p.Tutoria)
                .HasForeignKey(d => d.Cursoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tutorias_ibfk_1");
        });

        modelBuilder.Entity<TutoriasAlumno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("tutorias_alumnos")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Tutoriaid, "tutoriaid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acreditado).HasColumnName("acreditado");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("'1'")
                .HasColumnName("estado");
            entity.Property(e => e.Fechaacreditacion)
                .HasColumnType("datetime")
                .HasColumnName("fechaacreditacion");
            entity.Property(e => e.File)
                .HasColumnType("mediumblob")
                .HasColumnName("file");
            entity.Property(e => e.Filename)
                .HasColumnType("text")
                .HasColumnName("filename");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");
            entity.Property(e => e.Moodleuserid).HasColumnName("moodleuserid");
            entity.Property(e => e.Resolucion)
                .HasColumnType("text")
                .HasColumnName("resolucion");
            entity.Property(e => e.Tutoriaid).HasColumnName("tutoriaid");

            entity.HasOne(d => d.Tutoria).WithMany(p => p.TutoriasAlumnos)
                .HasForeignKey(d => d.Tutoriaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tutorias_alumnos_ibfk_1");
        });

        modelBuilder.Entity<TutoriasSesione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("tutorias_sesiones")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Alumnoid, "alumnoid");

            entity.HasIndex(e => e.Tutoriaid, "tutoriaid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alumnoid).HasColumnName("alumnoid");
            entity.Property(e => e.Asistencia).HasColumnName("asistencia");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("'1'")
                .HasColumnName("estado");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Firmaalumno)
                .HasColumnType("datetime")
                .HasColumnName("firmaalumno");
            entity.Property(e => e.Horafin)
                .HasColumnType("time")
                .HasColumnName("horafin");
            entity.Property(e => e.Horainicio)
                .HasColumnType("time")
                .HasColumnName("horainicio");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
            entity.Property(e => e.Tutoriaid).HasColumnName("tutoriaid");

            entity.HasOne(d => d.Alumno).WithMany(p => p.TutoriasSesiones)
                .HasForeignKey(d => d.Alumnoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tutorias_sesiones_ibfk_2");

            entity.HasOne(d => d.Tutoria).WithMany(p => p.TutoriasSesiones)
                .HasForeignKey(d => d.Tutoriaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tutorias_sesiones_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
