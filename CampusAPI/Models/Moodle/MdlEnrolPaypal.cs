using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Holds all known information about PayPal transactions
/// </summary>
public partial class MdlEnrolPaypal
{
    public long Id { get; set; }

    public string Business { get; set; } = null!;

    public string ReceiverEmail { get; set; } = null!;

    public string ReceiverId { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public long Courseid { get; set; }

    public long Userid { get; set; }

    public long Instanceid { get; set; }

    public string Memo { get; set; } = null!;

    public string Tax { get; set; } = null!;

    public string OptionName1 { get; set; } = null!;

    public string OptionSelection1X { get; set; } = null!;

    public string OptionName2 { get; set; } = null!;

    public string OptionSelection2X { get; set; } = null!;

    public string PaymentStatus { get; set; } = null!;

    public string PendingReason { get; set; } = null!;

    public string ReasonCode { get; set; } = null!;

    public string TxnId { get; set; } = null!;

    public string ParentTxnId { get; set; } = null!;

    public string PaymentType { get; set; } = null!;

    public long Timeupdated { get; set; }
}
