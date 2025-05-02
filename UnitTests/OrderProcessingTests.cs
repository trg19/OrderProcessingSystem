/******************************************************************************
* Filename    = OrderProcessingTests.cs
*
* Author      = Thanmayee
*
* Project     = OrderProcessingSystem
*
* Description = Unit tests for the project
*****************************************************************************/


using MediatorPatternDemo; // Import the MediatorPatternDemo namespace

namespace UnitTests
{
    [TestClass]
    public class OrderProcessingTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            IMediator mediator = new Mediator(); // Create a mediator
            Customer customers = new Customer(mediator, "Customer 1"); // Create a customer
            OrderProcessor processor = new OrderProcessor(mediator, "Processor 1"); // Create an order processor

            string orderDetails = "Test Order"; // Define order details

            // Act
            customers.PlaceOrder(orderDetails); // Place an order

            // Assert: Check if the order was received and processed (should be true)
            Assert.IsTrue(processor.OrderReceivedAndProcessed);
        }

        [TestMethod]
        // This test should output "Fail" as we are not placing any order
        public void TestMethod2()
        {
            // Arrange
            IMediator mediator = new Mediator(); // Create a mediator
            Customer customer = new Customer(mediator, "Customer 1"); // Create a customer
            OrderProcessor processor = new OrderProcessor(mediator, "Processor 1"); // Create an order processor

            string orderDetails = "Test Order"; // Define order details

            // Act: Do not place the order

            // Assert: Check if the order was not received and processed (should be false)
            Assert.IsFalse(processor.OrderReceivedAndProcessed);
        }
    }
}
