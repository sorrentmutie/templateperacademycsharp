using Template.Dati.Northwind.Models;

namespace Template.Console.UI;

public class OrderViewModel
{
    public int Id { get; init; }
    public DateTime? OrderDate { get; init; }
    public decimal TotalPrice { get; init; }
}


public static class OrderViewModelExtensions
{
    public static OrderViewModel ToViewModel(this Order order)
    {
        return new OrderViewModel
        {
            Id = order.OrderId,
            OrderDate = order.OrderDate,
            TotalPrice = order.OrderDetails.Sum(od => od.UnitPrice * od.Quantity * (1 - (decimal)od.Discount))
        };
    }

    public static List<OrderViewModel> ToListViewModel(this List<Order> orders)
    {
        return orders.Select(o => o.ToViewModel()).ToList();
    }

    public static void printOrders(this List<OrderViewModel> orders)
    {
        foreach (var item in orders)
        {
            System.Console.WriteLine($"OrderID: {item.Id} - OrderDate: {item.OrderDate} - Total Price: {item.TotalPrice}");
        }
    }

}
