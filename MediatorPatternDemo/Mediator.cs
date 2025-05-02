/******************************************************************************
* Filename    = Mediator.cs
*
* Author      = Thanmayee
* 
* Project     = OrderProcessingSystem
*
* Description = Contains the IMediator interface, specifying the contract for 
*               mediators in the Mediator pattern.It defines methods for 
*               registering customers, processing orders, and facilitating communication.
*****************************************************************************/

using System;
using System.Collections.Generic;

namespace MediatorPatternDemo
{ 
    public class Mediator : IMediator
    {
        private List<Customer> customers = new List<Customer>(); // List to store registered customers.
        private List<OrderProcessor> processors = new List<OrderProcessor>(); // List to store registered order processors.

        /// <summary>
        /// Registers a customer with the mediator.
        /// </summary>
        public void RegisterCustomer(Customer customer)
        {
            customers.Add(customer); // Add the customer to the list of registered customers.
        }

        /// <summary>
        /// Registers an order processor with the mediator.
        /// </summary>
        public void RegisterOrderProcessor(OrderProcessor processor)
        {
            processors.Add(processor); // Add the order processor to the list of registered processors.
        }

        /// <summary>
        /// Places an order on behalf of a customer and notifies all registered order processors.
        /// </summary>
        public void PlaceOrder(Customer customer, string orderDetails)
        {
            Console.WriteLine($"{customer.Name} placed an order: {orderDetails}");

            // Iterate through registered processors and process the order.
            foreach (var processor in processors)
            {
                ProcessOrder(processor, customer, orderDetails);
            }
        }

        /// <summary>
        /// Notifies an order processor about a new order received from a customer and marks it as processed.
        /// </summary>
        public void ProcessOrder(OrderProcessor processor, Customer customer, string orderDetails)
        {
            Console.WriteLine($"{processor.Name} received an order from {customer.Name}: {orderDetails}");
            processor.OrderReceivedAndProcessed = true; // Mark the order as received and processed by the processor.
        }
    }
}