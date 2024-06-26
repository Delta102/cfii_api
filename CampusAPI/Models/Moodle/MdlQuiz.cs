using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// The settings for each quiz.
/// </summary>
public partial class MdlQuiz
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string Intro { get; set; } = null!;

    public short Introformat { get; set; }

    public long Timeopen { get; set; }

    public long Timeclose { get; set; }

    public long Timelimit { get; set; }

    public string Overduehandling { get; set; } = null!;

    public long Graceperiod { get; set; }

    public string Preferredbehaviour { get; set; } = null!;

    public short Canredoquestions { get; set; }

    public int Attempts { get; set; }

    public short Attemptonlast { get; set; }

    public short Grademethod { get; set; }

    public short Decimalpoints { get; set; }

    public short Questiondecimalpoints { get; set; }

    public int Reviewattempt { get; set; }

    public int Reviewcorrectness { get; set; }

    public int Reviewmarks { get; set; }

    public int Reviewspecificfeedback { get; set; }

    public int Reviewgeneralfeedback { get; set; }

    public int Reviewrightanswer { get; set; }

    public int Reviewoverallfeedback { get; set; }

    public long Questionsperpage { get; set; }

    public string Navmethod { get; set; } = null!;

    public short Shuffleanswers { get; set; }

    public decimal Sumgrades { get; set; }

    public decimal Grade { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public string Password { get; set; } = null!;

    public string Subnet { get; set; } = null!;

    public string Browsersecurity { get; set; } = null!;

    public long Delay1 { get; set; }

    public long Delay2 { get; set; }

    public short Showuserpicture { get; set; }

    public short Showblocks { get; set; }

    public bool? Completionattemptsexhausted { get; set; }

    public bool? Completionpass { get; set; }

    public long Completionminattempts { get; set; }

    public bool? Allowofflineattempts { get; set; }
}
