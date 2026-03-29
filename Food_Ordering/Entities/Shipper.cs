using System;
using System.Collections.Generic;

namespace Food_Ordering.Entities;

public partial class Shipper
{
    public int ShipperId { get; set; }

    public string VehicleType { get; set; } = null!;

    public string LicensePlate { get; set; } = null!;

    public bool IsAvailable { get; set; }

    public int TotalDeliveries { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual User ShipperNavigation { get; set; } = null!;
}
