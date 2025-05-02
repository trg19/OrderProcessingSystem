/******************************************************************************
* Filename    = Customer.cs
*
* Author      = Thanmayee
* 
* Project     = OrderProcessingSystem
*
* Description = This file defines the Customer class, representing customers 
*               who place orders in the Mediator pattern.Customers utilize 
*               the Mediator to communicate their order details for processing.
*****************************************************************************/

using System;

namespace MediatorPatternDemo
{
    public class Customer
    {
        private readonly IMediator mediator; // Reference to the mediator for communication.
        public string Name { get; } //The name of the customer

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="mediator">The mediator to register with.</param>
        /// <param name="name">The name of the customer.</param>
        public Customer(IMediator mediator, string name)
        {
            this.mediator = mediator;
            Name = name;
            mediator.RegisterCustomer(this);
        }

        /// <summary>
        /// Places an order with the specified order details.
        /// </summary>
        public void PlaceOrder(string orderDetails)
        {
            mediator.PlaceOrder(this, orderDetails); // Request the mediator to place the order.
        }
    }


}
