using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores references from Google Meet recordings.
/// </summary>
public partial class MdlGooglemeetRecording
{
    public long Id { get; set; }

    public long Googlemeetid { get; set; }

    public string Recordingid { get; set; } = null!;

    public string Name { get; set; } = null!;

    public long Createdtime { get; set; }

    public string Duration { get; set; } = null!;

    public string Webviewlink { get; set; } = null!;

    public short Visible { get; set; }

    public long Timemodified { get; set; }
}
