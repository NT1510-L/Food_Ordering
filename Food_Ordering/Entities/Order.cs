using System;
using System.Collections.Generic;

namespace Food_Ordering.Entities;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public int RestaurantId { get; set; }

    public int? ShipperId { get; set; }

    public decimal TotalAmount { get; set; }

    public string DeliveryAddress { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string PaymentMethod { get; set; } = null!;

    public string? PaymentTransactionId { get; set; }

    public string? Note { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Restaurant Restaurant { get; set; } = null!;

    public virtual Shipper? Shipper { get; set; }
}
