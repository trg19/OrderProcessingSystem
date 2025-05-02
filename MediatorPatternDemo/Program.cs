/******************************************************************************
 * Filename    : Program.cs
 *
 * Author      : Thanmayee
 * 
 * Project     : OrderProcessingSystem
 *
 * Description : This file contains the main entry point of the program, showcasing the practical use of the Mediator pattern.
 *               It demonstrates how customers interact with order processors via the Mediator to place and fulfill orders.
 *****************************************************************************/

namespace MediatorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Mediator.
            IMediator mediator = new Mediator();

            // Create two customers and register them with the mediator.
            Customer customer1 = new Customer(mediator, "Customer 1");
            Customer customer2 = new Customer(mediator, "Customer 2");

            // Create two order processors.
            OrderProcessor processor1 = new OrderProcessor(mediator, "Processor 1");
            OrderProcessor processor2 = new OrderProcessor(mediator, "Processor 2");

            // Customers place orders.
            customer1.PlaceOrder("Order 1");
            customer2.PlaceOrder("Order 2");
        }
    }
}
