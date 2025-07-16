using OrderDataProcessor.Models;

namespace OrderDataProcessor.Orders
{

    public class OrderProcessor(List<Order> orders)
    {

        private readonly List<Order> _orders = orders;

        public int GetTotalOrders()
        {
            //TODO: Calculate total number of orders
            return 0; // Default. Remove to add logic
        }

        public decimal GetTotalAmount()
        {
            //TODO: Calculate total amount of all orders
            return 0.0m; // Default. Remove to add logic
        }

        public decimal GetAverageOrderAmount()
        {
            //TODO: Caclulate average order amount
            return 0.0m; // Default. Remove to add logic
        }

        public Dictionary<string, Decimal> GetTotalAmountPerCustomer()
        {
            //TODO: Caclulate the total order count and total amount by customer
            return [];// Default. Remove to add logic
        }

        public Dictionary<string, (int TotalOrders, decimal TotalAmount)> GetTotalOrdersAndTotalAmountPerMonth()
        {
            //TODO: Caclulate the total order count and total amount by month
            return [];  // Default. Remove to add logic
        }


    }

}