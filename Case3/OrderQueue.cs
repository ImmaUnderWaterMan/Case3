using System.Collections.Generic;
using BestDelivery;

public static class OrderQueue
{
    public static Queue<List<Order>> Queue { get; set; } = new Queue<List<Order>>();
}
