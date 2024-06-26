using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Associations of blog entries with courses and module instanc
/// </summary>
public partial class MdlBlogAssociation
{
    public long Id { get; set; }

    public long Contextid { get; set; }

    public long Blogid { get; set; }
}
