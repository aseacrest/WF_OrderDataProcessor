using OrderDataProcessor.Models;

namespace OrderDataProcessor.Orders
{

    public class OrderProcessor
    {

        private readonly List<Order> _orders;
        public OrderProcessor(List<Order> orders) => _orders = orders;

        public int GetTotalOrders()
        {
            //TODO: Calculate totla number of ordersS
            return 0; // Default. Remove to add logic
        }

        public decimal GetTotalRevenue()
        {
            //TODO: Calculate totla revenue
            return 0.0m; // Default. Remove to add logic
        }

        public decimal GetAverageOrderAmount()
        {
            //TODO: Caclulate average order amount
            return 0.0m; // Default. Remove to add logic
        }

        public Dictionary<string, Decimal> GetTotalSpentPerCustomer()
        {
            //TODO: Caclulate total number of orders by customers and total order value by customer
            return new Dictionary<string, decimal>();// Default. Remove to add logic
        }

        public Dictionary<string, (int TotlaOrders, decimal TotalAmount)> GetTotalOrdersAndTotalsAmountsPerMonth()
        {
            //TODO: Caclulate total number of orders by customers and total order value by customer
            return new Dictionary<string, (int TotlaOrders, decimal TotalAmount)>();  // Default. Remove to add logic
        }


    }

}