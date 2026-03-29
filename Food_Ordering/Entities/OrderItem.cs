using System;
using System.Collections.Generic;

namespace Food_Ordering.Entities;

public partial class OrderItem
{
    public int OrderItemId { get; set; }

    public int OrderId { get; set; }

    public int FoodItemId { get; set; }

    public string FoodName { get; set; } = null!;

    public decimal FoodPrice { get; set; }

    public int Quantity { get; set; }

    public virtual FoodItem FoodItem { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
