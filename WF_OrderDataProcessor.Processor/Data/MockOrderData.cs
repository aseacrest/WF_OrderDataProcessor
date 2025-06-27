using OrderDataProcessor.Models;

namespace OrderDataProcessor.Data
{
    public static class MockOrderData
    {
        public static List<Order> GetOrders()
        {
            return
             [
                    new Order { OrderId = 1, CustomerName = "Alice" , Amount = 120.50m, OrderDate  = new DateTime(2023,1,16)},
                    new Order { OrderId = 2, CustomerName = "Bob" , Amount = 75.00m, OrderDate  = new DateTime(2023,1,17)},
                    new Order { OrderId = 3, CustomerName = "Alice" , Amount = 200.00m, OrderDate  = new DateTime(2023,2,1)},
                    new Order { OrderId = 4, CustomerName = "Charlie" , Amount = 150.25m, OrderDate  = new DateTime(2023,2,5)},
                    new Order { OrderId = 5, CustomerName = "Bob" , Amount = 245.50m, OrderDate  = new DateTime(2023,4,10)},
                    new Order { OrderId = 6, CustomerName = "Charlie" , Amount = 175.00m, OrderDate  = new DateTime(2023,2,12)},
                    new Order { OrderId = 7, CustomerName = "Alice" , Amount = 130.00m, OrderDate  = new DateTime(2023,3,15)},
                    new Order { OrderId = 8, CustomerName = "David" , Amount = 90.00m, OrderDate  = new DateTime(2023,2,18)},
                    new Order { OrderId = 9, CustomerName = "Eve" , Amount = 110.75m, OrderDate  = new DateTime(2023,4,20)},
                    new Order { OrderId = 10, CustomerName = "David" , Amount = 60.00m, OrderDate  = new DateTime(2023,3,22)}
            ];
        }
    }

}