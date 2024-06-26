using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Zoom meetings and webinars
/// </summary>
public partial class MdlZoom
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string? Intro { get; set; }

    public short? Introformat { get; set; }

    public long? Grade { get; set; }

    public long MeetingId { get; set; }

    public string? StartUrl { get; set; }

    public string? JoinUrl { get; set; }

    public string? CreatedAt { get; set; }

    public string HostId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public long? StartTime { get; set; }

    public long? Timemodified { get; set; }

    public bool? Recurring { get; set; }

    public bool? RecurrenceType { get; set; }

    public sbyte? RepeatInterval { get; set; }

    public string? WeeklyDays { get; set; }

    public sbyte? MonthlyDay { get; set; }

    public sbyte? MonthlyWeek { get; set; }

    public bool? MonthlyWeekDay { get; set; }

    public bool? MonthlyRepeatOption { get; set; }

    public sbyte? EndTimes { get; set; }

    public long? EndDateTime { get; set; }

    public bool? EndDateOption { get; set; }

    public bool? Webinar { get; set; }

    public int? Duration { get; set; }

    public string? Timezone { get; set; }

    public string? Password { get; set; }

    public bool? OptionJbh { get; set; }

    public string? OptionStartType { get; set; }

    public bool? OptionHostVideo { get; set; }

    public bool? OptionParticipantsVideo { get; set; }

    public string? OptionAudio { get; set; }

    public bool? OptionMuteUponEntry { get; set; }

    public bool? OptionWaitingRoom { get; set; }

    public bool? OptionAuthenticatedUsers { get; set; }

    public string? OptionEncryptionType { get; set; }

    public bool? ExistsOnZoom { get; set; }

    public string? AlternativeHosts { get; set; }

    public bool? RecordingsVisibleDefault { get; set; }

    public bool? ShowSchedule { get; set; }

    public bool? ShowSecurity { get; set; }

    public bool? ShowMedia { get; set; }

    public string? OptionAutoRecording { get; set; }

    public bool? Registration { get; set; }
}
