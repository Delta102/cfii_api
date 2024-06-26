using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Contains accessibility check results summary information.
/// </summary>
public partial class MdlToolBrickfieldSummary
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public bool? Status { get; set; }

    public long? Activities { get; set; }

    public long? Activitiespassed { get; set; }

    public long? Activitiesfailed { get; set; }

    public long? Errorschecktype1 { get; set; }

    public long? Errorschecktype2 { get; set; }

    public long? Errorschecktype3 { get; set; }

    public long? Errorschecktype4 { get; set; }

    public long? Errorschecktype5 { get; set; }

    public long? Errorschecktype6 { get; set; }

    public long? Errorschecktype7 { get; set; }

    public long? Failedchecktype1 { get; set; }

    public long? Failedchecktype2 { get; set; }

    public long? Failedchecktype3 { get; set; }

    public long? Failedchecktype4 { get; set; }

    public long? Failedchecktype5 { get; set; }

    public long? Failedchecktype6 { get; set; }

    public long? Failedchecktype7 { get; set; }

    public long? Percentchecktype1 { get; set; }

    public long? Percentchecktype2 { get; set; }

    public long? Percentchecktype3 { get; set; }

    public long? Percentchecktype4 { get; set; }

    public long? Percentchecktype5 { get; set; }

    public long? Percentchecktype6 { get; set; }

    public long? Percentchecktype7 { get; set; }
}
