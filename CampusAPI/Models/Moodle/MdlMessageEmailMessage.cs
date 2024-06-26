using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlMessageEmailMessage
{
    public long Id { get; set; }

    public long Useridto { get; set; }

    public long Conversationid { get; set; }

    public long Messageid { get; set; }
}
