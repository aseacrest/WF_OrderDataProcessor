## Interviewee Instructions

To complete this exercise, use the instructions in the `README.md` file to implement the required methods in `OrderDataProcessor.cs` (specifically, the `OrderProcessor` class). Each method you implement should satisfy the corresponding unit tests in `MockOrderDataTests.cs`.

**Recommended Approach:**

1. **Read the README.md Carefully:**  
   The README.md outlines the required methods and their expected behavior. Make sure you understand what each method should do.

2. **Implement Methods One by One:**  
   - Start with `GetTotalOrders()`.  
   - After implementing, run the tests to check if this method passes.
   - Move on to `GetTotalRevenue()`, then `GetAverageOrderAmount()`, and so on.
   - After each method, run the tests to verify your implementation.

3. **Run Tests Frequently:**  
   Use the following command to run the tests after each method:
   ```sh
   dotnet test WF_OrderDataProcessor.Tests/WF_OrderDataProcessor.Tests.csproj
   ```
   This will help you catch issues early and ensure each method works as expected.

4. **Use the Test Output:**  
   If a test fails, read the error message to understand what needs to be fixed. Adjust your implementation accordingly.

5. **Complete All Methods:**  
   Continue until all tests in `MockOrderDataTests.cs` pass.

**Tip:**  
Use LINQ and C# collection methods to simplify your logic. Focus on correctness and clarity.
