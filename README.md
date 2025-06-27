# WF_OrderDataProcessor

## Overview

This project processes order data and provides analytics such as total orders, total revenue, average order amount, customer spending, and monthly summaries. The core logic should be implemented in `OrderDataProcessor.cs` (typically as the `OrderProcessor` class).

## Development Instructions

To develop `OrderDataProcessor.cs` so that all tests pass, follow these steps:

### 1. Implement the `OrderProcessor` Class

- The class should accept a list of `Order` objects (from `MockOrderData.GetOrders()` in tests) via its constructor.

### 2. Required Methods

Implement the following methods in `OrderProcessor`:

- `int GetTotalOrders()`:  
  Returns the total number of orders.

- `decimal GetTotalRevenue()`:  
  Returns the sum of all order amounts.

- `decimal GetAverageOrderAmount()`:  
  Returns the average order amount (total revenue divided by total orders).

- `Dictionary<string, decimal> GetTotalSpentPerCustomer()`:  
  Returns a dictionary mapping each customer name to their total spent.

- `Dictionary<string, (int TotalOrders, decimal TotalAmount)> GetTotalOrdersAndTotalsAmountsPerMonth()`:  
  Returns a dictionary where the key is a string in the format `"YYYY-MM"` and the value is a tuple containing the total number of orders and the total amount for that month.

### 3. Run and Validate Tests

- Use the following command to run tests and ensure your implementation is correct:
  ```sh
  dotnet test WF_OrderDataProcessor.Tests/WF_OrderDataProcessor.Tests.csproj
  ```
- All tests in `MockOrderDataTests.cs` should pass.

