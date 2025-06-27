using OrderDataProcessor.Models;

namespace OrderDataProcessor.Orders
{

    public class OrderProcessor(List<Order> orders)
    {

        private readonly List<Order> _orders = orders;

        public static int GetTotalOrders()
        {
            //TODO: Calculate total number of orders
            return 0; // Default. Remove to add logic
        }

        public static decimal GetTotalRevenue()
        {
            //TODO: Calculate total revenue
            return 0.0m; // Default. Remove to add logic
        }

        public static decimal GetAverageOrderAmount()
        {
            //TODO: Caclulate average order amount
            return 0.0m; // Default. Remove to add logic
        }

        public static Dictionary<string, Decimal> GetTotalSpentPerCustomer()
        {
            //TODO: Caclulate the total order count and total amount by customer
            return [];// Default. Remove to add logic
        }

        public static Dictionary<string, (int TotalOrders, decimal TotalAmount)> GetTotalOrdersAndTotalsAmountsPerMonth()
        {
            //TODO: Caclulate the total order count and total amount by month
            return [];  // Default. Remove to add logic
        }


    }

}