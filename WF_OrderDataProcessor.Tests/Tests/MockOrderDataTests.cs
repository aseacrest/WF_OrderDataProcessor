
using NUnit.Framework.Internal;
using OrderDataProcessor.Data;
using OrderDataProcessor.Models;
using OrderDataProcessor.Orders;

[TestFixture]
public class OrderProcessorTests
{
    private OrderProcessor? _orderProcessor;
    private List<Order>? _mockOrders;

    [SetUp]
    public void Setup()
    {
        _mockOrders = MockOrderData.GetOrders();
        _orderProcessor = new OrderProcessor(_mockOrders);
    }

    [Test]
    public void GetTotalOrders_ShouldReturnCorrectCount()
    {
        var totalOrders = _orderProcessor != null ? _orderProcessor.GetTotalOrders() : throw new InvalidOperationException("_orderprocessor is not initialized.");

        Assert.That(totalOrders, Is.EqualTo(10), "The total number of orders should be 10");
    }

    [Test]
    public void GetTotalRevenue_ShouldReturnCorrectSum()
    {
        var totalRevenue = _orderProcessor != null ? _orderProcessor.GetTotalAmount() : throw new InvalidOperationException("_orderprocessor is not initialized.");

        Assert.That(totalRevenue, Is.EqualTo(1357.00m), "The total revenue should be 1,357.00");
    }

    [Test]
    public void GetAverageOrderAmount_ShouldReturnCorrectAverage()
    {
        var averageOrderAmount = _orderProcessor != null ? _orderProcessor.GetAverageOrderAmount() : throw new InvalidOperationException("_orderprocessor is not initialized.");
        Assert.That(averageOrderAmount, Is.EqualTo(135.70m).Within(0.01m), "The average order amount should be 135.70");

    }

    [Test]
    public void GetTotalSpentPerCustomer_ShouldReturnCorrectAmounts()
    {
        var totalSpentPerCustomer = _orderProcessor != null ? _orderProcessor.GetTotalAmountPerCustomer() : throw new InvalidOperationException("_orderprocessor is not initialized.");


        Assert.That(totalSpentPerCustomer["Alice"], Is.EqualTo(450.50m), "Alice's total spent should be 450.50.");
        Assert.That(totalSpentPerCustomer["Bob"], Is.EqualTo(320.50m), "Bob's total spent should be 320.50.");
        Assert.That(totalSpentPerCustomer["Charlie"], Is.EqualTo(325.25m), "Charlie's total spent should be 325.25.");
        Assert.That(totalSpentPerCustomer["David"], Is.EqualTo(150.00m), "David's total spent should be 150.00.");
        Assert.That(totalSpentPerCustomer["Eve"], Is.EqualTo(110.75m), "Eve's total spent should be 110.75.");

    }

    [Test]
    public void GetTotalOrderCountsAndTotalOrderAmountPerMonth_ShouldReturnCorrectData()
    {

        var expectedResults = new Dictionary<String, (int TotalOrders, decimal TotalAmount)>
        {
            {"2023-01",(2, 195.50m) },
            {"2023-02",(4, 615.25m) },
            {"2023-04",(2, 356.25m) },
            {"2023-03",(2, 190.00m) }

        };


        var results = _orderProcessor != null ? _orderProcessor.GetTotalOrdersAndTotalAmountPerMonth() : throw new InvalidOperationException("_orderprocessor is not initialized.");
        Assert.That(results, Is.Not.Null, "Results should not be null.");

        foreach (var expected in expectedResults)
        {
            Assert.That(results != null && results.ContainsKey(expected.Key), Is.True, $"Result should contain key {expected.Key}.");
            Assert.That(results, Is.Not.Null, "Results should not be null.");
            Assert.That(results![expected.Key].TotalOrders, Is.EqualTo(expected.Value.TotalOrders), $"Total orders for {expected.Key} should match.");
            Assert.That(results![expected.Key].TotalAmount, Is.EqualTo(expected.Value.TotalAmount), $"Total amount for {expected.Key} should match.");

        }

    }


}