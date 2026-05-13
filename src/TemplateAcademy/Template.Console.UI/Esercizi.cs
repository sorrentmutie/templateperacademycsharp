using Microsoft.EntityFrameworkCore;
using Template.Console.UI.ViewModel;
using Template.Dati.Northwind.Models;

namespace Template.Console.UI;

public static class Esercizi
{
    public static async Task esercizio1()
    {
        var dataabase = new NorthwindContext();
        var oders = await dataabase.Orders.ToListAsync();

        foreach (var item in oders)
        {
            //            System.Console.WriteLine($"OrderID: {item.OrderId} - CustomerID: {item.CustomerId} - EmployeeID: {item.EmployeeId} - OrderDate: {item.OrderDate}");
            System.Console.WriteLine($"OrderID: {item.OrderId} - OrderDate: {item.OrderDate}");

        }

    }

    public static async Task esercizio2()
    {
        var dataabase = new NorthwindContext();
        var orders = await dataabase.Orders.Include(o => o.OrderDetails)
            .Select(o =>
            new OrderViewModel
            {
                Id = o.OrderId,
                OrderDate = o.OrderDate,
                TotalPrice = o.OrderDetails.Sum(od => od.UnitPrice * od.Quantity * (1 - (decimal)od.Discount))
            })
            .ToListAsync();

        foreach (var item in orders)
        {
            System.Console.WriteLine($"OrderID: {item.Id} - OrderDate: {item.OrderDate} - Total Price: {item.TotalPrice}");
        }
    }

    public static async Task esercizio3()
    {

        var database = new NorthwindContext();

        (
        await database.Orders
        .Include(o => o.OrderDetails)
        .ToListAsync()
        )
        .ToListViewModel()
        .printOrders();

    }

    public static async Task esercizio4()
    {
        var database = new NorthwindContext();
        var mostSoldProduct = (await database.Products.Include(p => p.OrderDetails)
            .Select(p => new ProductViewModel
            {
                Id = p.ProductId,
                Name = p.ProductName,
                TotalQuantityOrdered = p.OrderDetails.Sum(od => od.Quantity)
            })
            .ToListAsync()).MaxBy(p => p.TotalQuantityOrdered);

    }

    public static async Task esercizio5()
    {
        var database = new NorthwindContext();
        var mostSoldProduct = await database.Products
    .Select(p => new ProductViewModel
    {
        Id = p.ProductId,
        Name = p.ProductName,
        TotalQuantityOrdered = p.OrderDetails.Sum(od => od.Quantity)
    })
    .OrderByDescending(p => p.TotalQuantityOrdered)
    .FirstOrDefaultAsync();
        System.Console.WriteLine($"{mostSoldProduct?.Name} - {mostSoldProduct?.TotalQuantityOrdered}");
    }
}

