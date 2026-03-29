using System;
using System.Collections.Generic;

namespace Food_Ordering.Entities;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? Address { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public virtual Cart? Cart { get; set; }

    public virtual User CustomerNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
