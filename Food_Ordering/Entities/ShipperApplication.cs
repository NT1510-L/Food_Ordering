using System;
using System.Collections.Generic;

namespace Food_Ordering.Entities;

public partial class ShipperApplication
{
    public int ApplicationId { get; set; }

    public int UserId { get; set; }

    public string VehicleType { get; set; } = null!;

    public string LicensePlate { get; set; } = null!;

    public string IdentityCard { get; set; } = null!;

    public string? IdentityCardFrontUrl { get; set; }

    public string? IdentityCardBackUrl { get; set; }

    public string Status { get; set; } = null!;

    public string? AdminNote { get; set; }

    public DateTime SubmittedAt { get; set; }

    public DateTime? ReviewedAt { get; set; }

    public virtual User User { get; set; } = null!;
}
