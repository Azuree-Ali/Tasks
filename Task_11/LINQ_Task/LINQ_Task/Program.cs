using Microsoft.EntityFrameworkCore;

namespace LINQ_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BikeStoresAliContext _context = new BikeStoresAliContext();
            // Q1 : 
            //var Customer = _context.Customers.Select(c=> new
            //{
            //    c.FirstName,
            //    c.LastName,
            //    c.Email,
            //});
            //foreach (var customer in Customer) {
            //    Console.WriteLine($"{customer.FirstName} , {customer.LastName} , {customer.Email}");
            //}


            // Q2 : 
            //var Orders = _context.Orders.Where(o => o.StaffId == 3);
            //foreach (var order in Orders)
            //{
            //    Console.WriteLine($"{order.StaffId} , {order.OrderId} , {order.CustomerId} , {order.OrderDate} , {order.OrderStatus} , {order.RequiredDate} , {order.ShippedDate} , {order.StoreId}");
            //}

            // Q3 : 
            //var ProductsWithCat = _context.Categories.Include(c=> c.Products).Where(c=> c.CategoryName == "Mountain Bikes");
            //foreach (var category in ProductsWithCat) {
            //    Console.WriteLine($"{category.CategoryId}");
            //}

            // Q4 :
            //var OrderStore = _context.Orders.GroupBy(o=> o.StoreId).Select(g=> new
            //{
            //    StoreId = g.Key,
            //    OrdersCount = g.Count()
            //});
            //foreach (var item in OrderStore)
            //{
            //    Console.WriteLine($"StoreId: {item.StoreId}, OrdersCount: {item.OrdersCount}");
            //}

            // Q5 :
            //var OrderShipped = _context.Orders.Where(o => o.ShippedDate == null);
            //foreach (var order in OrderShipped)
            //{
            //    Console.WriteLine($"OrderId: {order.OrderId}, ShippedDate: {order.ShippedDate}");
            //}

            // Q6 :
            //var CustomerOrders = _context.Customers.Include(c => c.Orders).Select(c => new
            //{
            //    c.FirstName,
            //    c.LastName,
            //    OrdersCount = c.Orders.Count()
            //});
            //foreach (var customer in CustomerOrders)
            //{
            //    Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName}, Orders Count: {customer.OrdersCount}");
            //}

            // Q7 :
            //var productNotOrded = _context.Products.Where(p => !p.OrderItems.Any());
            //foreach (var product in productNotOrded)
            //{
            //    Console.WriteLine($"ProductId: {product.ProductId}, ProductName: {product.ProductName}");
            //}

            // Q8 :
            //var productWithStock = _context.Products.Include(p => p.Stocks).Where(p => p.Stocks.Any(s => s.Quantity < 5));
            //foreach (var product in productWithStock)
            //{
            //    Console.WriteLine($"ProductId: {product.ProductId}, ProductName: {product.ProductName}");
            //}

            // Q9 :
            //var FirstProduct = _context.Products.First();
            //Console.WriteLine($"First Product: {FirstProduct.ProductId}, {FirstProduct.ProductName}");

            // Q10 :
            //var ProductCerYears = _context.Products.Where(p => p.ModelYear == 2017).Select(p => new
            //{
            //    p.ProductId,
            //    p.ProductName,
            //    p.ModelYear
            //});
            //foreach (var product in ProductCerYears)
            //{
            //    Console.WriteLine($"ProductId: {product.ProductId}, ProductName: {product.ProductName}, ModelYear: {product.ModelYear}"); Console.WriteLine(product.ProductName);
            //}

            // Q11 :
            //var productOrderCount = _context.Products.Select(p => new
            //{
            //    p.ProductId,
            //    p.ProductName,
            //    OrderCount = p.OrderItems.Count()
            //});
            //foreach (var product in productOrderCount)
            //{
            //    Console.WriteLine($"ProductId: {product.ProductId}, ProductName: {product.ProductName}, OrderCount: {product.OrderCount}");
            //}

            // Q12 :
            //var productCountWithCategory = _context.Categories.Select(c => new
            //{
            //    c.CategoryId,
            //    c.CategoryName,
            //    ProductCount = c.Products.Count()
            //});
            //foreach (var category in productCountWithCategory)
            //{
            //    Console.WriteLine($"CategoryId: {category.CategoryId}, CategoryName: {category.CategoryName}, ProductCount: {category.ProductCount}");
            //}

            //// Q13 :
            //var ProductAvgPrice = _context.Products.Average(p => p.ListPrice);
            //Console.WriteLine($"ProductAvgPrice: {ProductAvgPrice}");

            // Q14 :
            //var ProductByID = _context.Products.Where(p => p.ProductId == 1).Select(p => new
            //{
            //    p.ProductId,
            //    p.ProductName,
            //    p.ListPrice
            //}).FirstOrDefault();
            //if (ProductByID != null)
            //{
            //    Console.WriteLine($"ProductId: {ProductByID.ProductId}, ProductName: {ProductByID.ProductName}, ListPrice: {ProductByID.ListPrice}");
            //}

            // Q15 :
            //var products = _context.Products.Where(p => p.OrderItems.Any(oi => oi.ProductId == p.ProductId && oi.Quantity > 3));
            //foreach (var product in products)
            //{
            //    Console.WriteLine($"ProductId: {product.ProductId}, ProductName: {product.ProductName}");
            //}

            // Q16 :
            //var StaffWithOrders = _context.Staffs.Include(s => s.Orders).Where(s => s.Orders.Any());
            //foreach (var staff in StaffWithOrders)
            //{
            //    Console.WriteLine($"StaffId: {staff.StaffId}, FirstName: {staff.FirstName}, LastName: {staff.LastName}");
            //}

            //  Q17 :
            //var StaffActive = _context.Staffs.Where(s => s.Active == true);
            //foreach (var staff in StaffActive)
            //{
            //    Console.WriteLine($"StaffId: {staff.StaffId}, FirstName: {staff.FirstName}, LastName: {staff.LastName}");
            //}

            // Q18 :
            //var ProductWithBrandWithCategory = _context.Products.Include(p => p.Brand).Include(p => p.Category).Select(p => new
            //{
            //    p.ProductId,
            //    p.ProductName,
            //    BrandName = p.Brand.BrandName,
            //    CategoryName = p.Category.CategoryName
            //});
            //foreach (var product in ProductWithBrandWithCategory)
            //{
            //    Console.WriteLine($"ProductId: {product.ProductId}, ProductName: {product.ProductName}, BrandName: {product.BrandName}, CategoryName: {product.CategoryName}");
            //}

            // Q19 :
            //var OrdersComplete = _context.Orders.Where(o => o.OrderStatus == "Complete");
            //foreach (var order in OrdersComplete)
            //{
            //    Console.WriteLine($"OrderId: {order.OrderId}, OrderStatus: {order.OrderStatus}");
            //}
        

            // Q20 :
            //var ProductWithOrderItems = _context.Products.Include(p => p.OrderItems).GroupBy(p => p.ProductId).Select(p => new
            //{
            //    ProductId = p.Key,
            //    Total = p.Sum(p => p.OrderItems.Sum(oi => oi.Quantity))
            //});
            //foreach (var product in ProductWithOrderItems)
            //{
            //    Console.WriteLine($"ProductId: {product.ProductId}, Total Quantity Ordered: {product.Total}");
            //}
        }
    }
}
