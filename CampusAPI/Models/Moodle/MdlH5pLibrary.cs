using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlH5pLibrary
{
    public long Id { get; set; }

    public string Machinename { get; set; } = null!;

    public string Title { get; set; } = null!;

    public short Majorversion { get; set; }

    public short Minorversion { get; set; }

    public short Patchversion { get; set; }

    public bool Runnable { get; set; }

    public bool Fullscreen { get; set; }

    public string Embedtypes { get; set; } = null!;

    public string? Preloadedjs { get; set; }

    public string? Preloadedcss { get; set; }

    public string? Droplibrarycss { get; set; }

    public string? Semantics { get; set; }

    public string? Addto { get; set; }

    public short? Coremajor { get; set; }

    public short? Coreminor { get; set; }

    public string? Metadatasettings { get; set; }

    public string? Tutorial { get; set; }

    public string? Example { get; set; }

    public bool? Enabled { get; set; }
}
