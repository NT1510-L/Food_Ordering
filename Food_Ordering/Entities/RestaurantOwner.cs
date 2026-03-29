using System;
using System.Collections.Generic;

namespace Food_Ordering.Entities;

public partial class RestaurantOwner
{
    public int OwnerId { get; set; }

    public virtual User Owner { get; set; } = null!;

    public virtual Restaurant? Restaurant { get; set; }
}
