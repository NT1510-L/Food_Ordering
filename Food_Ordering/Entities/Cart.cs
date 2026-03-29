using System;
using System.Collections.Generic;

namespace Food_Ordering.Entities;

public partial class Cart
{
    public int CartId { get; set; }

    public int CustomerId { get; set; }

    public int? RestaurantId { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual Customer Customer { get; set; } = null!;

    public virtual Restaurant? Restaurant { get; set; }
}
