using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the quiz level Safe Exam Browser configuration.
/// </summary>
public partial class MdlQuizaccessSebQuizsetting
{
    public long Id { get; set; }

    public long Quizid { get; set; }

    public long Cmid { get; set; }

    public long Templateid { get; set; }

    public bool Requiresafeexambrowser { get; set; }

    public bool? Showsebtaskbar { get; set; }

    public bool? Showwificontrol { get; set; }

    public bool? Showreloadbutton { get; set; }

    public bool? Showtime { get; set; }

    public bool? Showkeyboardlayout { get; set; }

    public bool? Allowuserquitseb { get; set; }

    public string? Quitpassword { get; set; }

    public string? Linkquitseb { get; set; }

    public bool? Userconfirmquit { get; set; }

    public bool? Enableaudiocontrol { get; set; }

    public bool? Muteonstartup { get; set; }

    public bool? Allowspellchecking { get; set; }

    public bool? Allowreloadinexam { get; set; }

    public bool? Activateurlfiltering { get; set; }

    public bool? Filterembeddedcontent { get; set; }

    public string? Expressionsallowed { get; set; }

    public string? Regexallowed { get; set; }

    public string? Expressionsblocked { get; set; }

    public string? Regexblocked { get; set; }

    public string? Allowedbrowserexamkeys { get; set; }

    public bool? Showsebdownloadlink { get; set; }

    public long Usermodified { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
