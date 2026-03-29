using System;
using System.Collections.Generic;

namespace Food_Ordering.Entities;

public partial class CartItem
{
    public int CartItemId { get; set; }

    public int CartId { get; set; }

    public int FoodItemId { get; set; }

    public int Quantity { get; set; }

    public virtual Cart Cart { get; set; } = null!;

    public virtual FoodItem FoodItem { get; set; } = null!;
}
