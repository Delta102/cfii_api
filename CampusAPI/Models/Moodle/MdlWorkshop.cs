using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This table keeps information about the module instances and 
/// </summary>
public partial class MdlWorkshop
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string? Intro { get; set; }

    public short Introformat { get; set; }

    public string? Instructauthors { get; set; }

    public short Instructauthorsformat { get; set; }

    public string? Instructreviewers { get; set; }

    public short Instructreviewersformat { get; set; }

    public long Timemodified { get; set; }

    public short? Phase { get; set; }

    public sbyte? Useexamples { get; set; }

    public sbyte? Usepeerassessment { get; set; }

    public sbyte? Useselfassessment { get; set; }

    public decimal? Grade { get; set; }

    public decimal? Gradinggrade { get; set; }

    public string Strategy { get; set; } = null!;

    public string Evaluation { get; set; } = null!;

    public short? Gradedecimals { get; set; }

    public bool? Submissiontypetext { get; set; }

    public bool? Submissiontypefile { get; set; }

    public short? Nattachments { get; set; }

    public string? Submissionfiletypes { get; set; }

    public sbyte? Latesubmissions { get; set; }

    public long? Maxbytes { get; set; }

    public short? Examplesmode { get; set; }

    public long? Submissionstart { get; set; }

    public long? Submissionend { get; set; }

    public long? Assessmentstart { get; set; }

    public long? Assessmentend { get; set; }

    public sbyte Phaseswitchassessment { get; set; }

    public string? Conclusion { get; set; }

    public short Conclusionformat { get; set; }

    public short? Overallfeedbackmode { get; set; }

    public short? Overallfeedbackfiles { get; set; }

    public string? Overallfeedbackfiletypes { get; set; }

    public long? Overallfeedbackmaxbytes { get; set; }
}
