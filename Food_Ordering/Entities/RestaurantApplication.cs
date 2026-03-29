using System;
using System.Collections.Generic;

namespace Food_Ordering.Entities;

public partial class RestaurantApplication
{
    public int ApplicationId { get; set; }

    public int UserId { get; set; }

    public string RestaurantName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public string? Description { get; set; }

    public string? LogoUrl { get; set; }

    public TimeOnly? OpenTime { get; set; }

    public TimeOnly? CloseTime { get; set; }

    public string Status { get; set; } = null!;

    public string? AdminNote { get; set; }

    public DateTime SubmittedAt { get; set; }

    public DateTime? ReviewedAt { get; set; }

    public virtual User User { get; set; } = null!;
}
