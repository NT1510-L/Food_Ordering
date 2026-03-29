using System;
using System.Collections.Generic;

namespace Food_Ordering.Entities;

public partial class User
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? AvatarUrl { get; set; }

    public string Role { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<RestaurantApplication> RestaurantApplications { get; set; } = new List<RestaurantApplication>();

    public virtual RestaurantOwner? RestaurantOwner { get; set; }

    public virtual Shipper? Shipper { get; set; }

    public virtual ICollection<ShipperApplication> ShipperApplications { get; set; } = new List<ShipperApplication>();
}
