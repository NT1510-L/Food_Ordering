using System;
using System.Collections.Generic;

namespace Food_Ordering.Entities;

public partial class Restaurant
{
    public int RestaurantId { get; set; }

    public int OwnerId { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public string? Description { get; set; }

    public string? LogoUrl { get; set; }

    public TimeOnly? OpenTime { get; set; }

    public TimeOnly? CloseTime { get; set; }

    public bool IsOpen { get; set; }

    public decimal AverageRating { get; set; }

    public int TotalOrders { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ICollection<FoodItem> FoodItems { get; set; } = new List<FoodItem>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual RestaurantOwner Owner { get; set; } = null!;
}
