namespace OrderDataProcessor.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public required string CustomerName { get; set; }
        public decimal Amount { get; set; }
        public DateTime OrderDate { get; set; }

    }

}